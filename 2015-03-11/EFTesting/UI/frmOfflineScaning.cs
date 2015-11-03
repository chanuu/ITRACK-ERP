using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Office.Utils;
using ITRACK.models;
using System.Linq.Expressions;
using EFTesting.ViewModel;

namespace EFTesting.UI
{
    public partial class frmOfflineScaning : DevExpress.XtraEditors.XtraForm
    {
        public frmOfflineScaning()
        {
            InitializeComponent();
        }



        void SearchScanSchadual(Int16 id) {

            try {
                GenaricRepository<ScaningTimeSchadual> _ScaningTimeSchadualRepository = new GenaricRepository<ScaningTimeSchadual>(new ItrackContext());

                var list = from item in _ScaningTimeSchadualRepository.GetAll().ToList()
                           where item.ScaningTimeSchadualID == id
                           select new { item.ScaningTimeSchadualID, item.HourNO, item.ScaningTime };

                if (list.Count() > 0)
                {
                    grdSearch.DataSource = list;

                }
              

                

            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }



        private void Search()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(ScaningTimeSchadual), "s");
                Expression nameProperty = Expression.Property(argParam, "ScaningTime");
                Expression namespaceProperty = Expression.Property(argParam, "ScaningTime");

                var val1 = Expression.Constant(txtScanTime.Text);
                var val2 = Expression.Constant(txtScanTime.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                GenaricRepository<ScaningTimeSchadual> _ScaningTimeSchadualRepository = new GenaricRepository<ScaningTimeSchadual>(new ItrackContext());
                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<ScaningTimeSchadual, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _ScaningTimeSchadualRepository.SearchFor(lambda1).ToList() select new { item.ScaningTimeSchadualID, item.HourNO, item.ScaningTime };
                grdSearch.Show();
                //check is record exist in selected item
                if (selected.Count() > 0)
                {



                    grdSearch.DataSource = selected;
                }
                else
                {
                    grdSearch.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtHourNo_EditValueChanged(object sender, EventArgs e)
        {

            Search();
        }

        private void txtHourNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearch.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearch.Hide();

            }
        }



        private bool ProcessTextFile()
        {

            // textfileOpen.Filter = "Text Files (*.txt) | *.doc";
            textfileOpen.InitialDirectory = @"C:\";
            textfileOpen.Title = "Select Text File To Process";
            TextFileReadingHelper _helper = new TextFileReadingHelper();
            if (textfileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                string _path = textfileOpen.FileName;

                txtLocation.Text = _path;



            }

            return true;

        }

        Employee _employee = new Employee();

        TextFileReadingHelper _helper = new TextFileReadingHelper();
        public string BarcodeID { get; set; }
        public string Grade { get; set; }

        public string Role { get; set; }



        private void DoScan(){


            foreach (var Line in _helper.getAllLines(txtLocation.Text))
            {

                if (Line.Length == 5)
                {
                    GenaricRepository<Employee> _EmployeeRepos = new GenaricRepository<Employee>(new ItrackContext());
                    var emplist = _EmployeeRepos.GetAll().Where(x => x.EmployeeID == Line);
                    if (emplist.Count() > 0)
                    {
                        _employee.EmployeeID = Line;
                       
                        txtLog.MaskBox.AppendText("Emp No  -> :" + _employee.EmployeeID + "" + "\r\n");

                    }
                    else
                    {

                        Debug.WriteLine("Error :" + Line + "\r\n");


                        txtLog.MaskBox.AppendText("Error   ->Canot find emplayee ID :" + Line + "" + "\r\n");

                    }

                    
                }
                else if (Line.Length == 6)
                {

                    offlineScaning(Line);
                  //  Debug.WriteLine(Line);
                 
                   
                }

            }
        
        }

        private void offlineScaning(string _barcode)
        {
            try
            {
                GenaricRepository<OprationBarcodes> _BarcodeRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
                GenaricRepository<OprationBarcodes> _BarcodeEditRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
                foreach (var barcode in _BarcodeRepository.GetAll().Where(p => p.OprationBarcodesID == _barcode).ToList())
                {
                    OprationBarcodes _sbarcode = new OprationBarcodes();
                    _sbarcode.OprationComplteAt = Convert.ToDateTime(txtDate.Text + " " + txtScanTime.Text);
                    _sbarcode.isOparationComplete = true;
                    _sbarcode.EmployeeID = _employee.EmployeeID;
                    _sbarcode.OprationBarcodesID = this.BarcodeID;
                    _sbarcode.OprationNO = barcode.OprationNO; ;
                    _sbarcode.OparationName = barcode.OparationName;
                    _sbarcode.OprationGrade = barcode.OprationGrade;
                    _sbarcode.OprationRole = barcode.OprationRole;
                    _sbarcode.BundleDetailsID = barcode.BundleDetails.BundleDetailsID;
                    _sbarcode.PartName = barcode.PartName;
                    _sbarcode.LineNo = barcode.LineNo;
                    _sbarcode.StyleNo = barcode.StyleNo;
                    _sbarcode.OprationBarcodesID = _barcode;
                    _sbarcode.OperationPoolID = barcode.OprationNO;
                    _sbarcode.HourNo = txtHourNo.Text;
                    txtLog.MaskBox.AppendText("Barcode ID  -> :" + _barcode + "  - Operation No :" + _sbarcode.OprationNO + "  Operation Name:" + _sbarcode.OparationName + "\r\n");
                    _BarcodeEditRepository.Update(_sbarcode);
                    

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }



        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) {
                txtScanTime.Text = gridView4.GetFocusedRowCellValue("ScaningTime").ToString();
                txtHourNo.Text = gridView4.GetFocusedRowCellValue("HourNO").ToString();
                grdSearch.Hide();
            }
            
          
        }

        private void frmOfflineScaning_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ProcessTextFile();
        }

        private void txtScanTime_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DoScan();
        }
    }
}