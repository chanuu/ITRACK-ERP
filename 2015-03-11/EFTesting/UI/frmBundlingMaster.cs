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
using System.Linq.Expressions;
using ITRACK.models;
using System.Diagnostics;
using EFTesting.ViewModel;

namespace EFTesting.UI
{
    public partial class frmBundlingMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmBundlingMaster()
        {
            InitializeComponent();
        }

        CuttingHeader _cuttingHeader = new CuttingHeader();
        CuttingItem _cuttingItem = new CuttingItem();
        #region CRUD

    /// <summary>
    /// 
    /// </summary>
        private void SearchCuttingHeader()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(CuttingHeader), "s");
                Expression nameProperty = Expression.Property(argParam, "CuttingHeaderID");
                Expression namespaceProperty = Expression.Property(argParam, "StyleID");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<CuttingHeader, bool>>(andExp, argParam);
                // pass object to query 
                GenaricRepository<CuttingHeader> _SearchHeaderRepository = new GenaricRepository<CuttingHeader>(new ItrackContext());
                var selected = from item in _SearchHeaderRepository.SearchFor(lambda1).ToList() select new { item.CuttingHeaderID, item.StyleID, item.OrderQuantity, item.Date, item.Remark };

                //check is record exist in selected item
               if (selected.Count() > 0)
                {
                    grdSearch.Show();
                    btnClose.Show();

                    grdSearch.DataSource = selected;
                }
                else
                {
                    grdSearch.DataSource = null;
                }



            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private List<CuttingHeader> GetCuttingByID(string ID)
        {
            try
            {
                GenaricRepository<CuttingHeader> _SearchHeaderRepository = new GenaricRepository<CuttingHeader>(new ItrackContext());
                return _SearchHeaderRepository.GetAll().Where(u => u.CuttingHeaderID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        void getCuttingFeild(string ID)
        {
            try
            {

                foreach (var header in GetCuttingByID(ID))
                {


                    _cuttingHeader.CuttingHeaderID = header.CuttingHeaderID;
                    txtCuttingTicketNo.Text = header.CuttingHeaderID;
                    txtStyleNo.Text = header.StyleID;
                    txtPlanQty.Text = Convert.ToString(header.PlanQuantity);
                    txtOrderQty.Text = Convert.ToString(header.OrderQuantity);
                





                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private List<CuttingItem> GetCuttingItemByID(string ID)
        {
            try
            {
                GenaricRepository<CuttingItem> _CuttingItem = new GenaricRepository<CuttingItem>(new ItrackContext());
                return _CuttingItem.GetAll().Where(u => u.CuttingHeaderID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }


       
        // check if exist bundle header related to cutting item and remove it from to genarate grid
        List<CuttingItem> RemovedItem(List<CuttingItem> lst)
        {
            try {
                List<CuttingItem> lstItems = new List<CuttingItem>();
              
                int i = 0;
           
                 GenaricRepository<BundleHeader> _bhRepo = new GenaricRepository<BundleHeader>(new ItrackContext());
                 foreach (var items in lst)
                 {


                     if (_bhRepo.GetAll().ToList().Any(item => item.CuttingItemID == items.CuttingItemID) == true)
                     {
                      
                     }
                     else {
                         lstItems.Add(items);
                     }

                    i = i + 1;
                    
                    }


                 return lstItems;

            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
             
            }
        }




        List<CuttingItem> PrintBundleItem(List<CuttingItem> lst)
        {
            try
            {
                List<CuttingItem> lstItemsPrint = new List<CuttingItem>();

                int i = 0;

                GenaricRepository<BundleHeader> _bhRepo = new GenaricRepository<BundleHeader>(new ItrackContext());
                foreach (var items in lst)
                {


                    if (_bhRepo.GetAll().ToList().Any(item => item.CuttingItemID == items.CuttingItemID) == true)
                    {
                        lstItemsPrint.Add(items);
                    }
                    else
                    {
                      
                    }

                    i = i + 1;

                }


                return lstItemsPrint;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_headerId"></param>
        private void FeedCuttingItem(string _headerId)
        {
            try
            {
               Debug.WriteLine(RemovedItem(GetCuttingItemByID(_headerId)).Count);
                
                grdItemList.DataSource =RemovedItem(GetCuttingItemByID(_headerId));

                grdBundleTicket.DataSource = PrintBundleItem(GetCuttingItemByID(_headerId));
                gridView2.Columns["CuttingHeader"].Visible = false;
                gridView2.Columns["CuttingHeaderID"].Visible = false;
                gridView2.Columns["BundleHeader"].Visible = false;

                gridView1.Columns["CuttingHeader"].Visible = false;
                gridView1.Columns["CuttingHeaderID"].Visible = false;
                gridView1.Columns["BundleHeader"].Visible = false;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }


        }

        /// <summary>
        /// 
        /// </summary>
        private void GenareteTags() {
            try {
                AddBundleHeader();
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
            }
        }

        private void AddBundleHeader()
        {
            try
            {
                GenaricRepository<BundleHeader> _BundleHeaderRepository = new GenaricRepository<BundleHeader>(new ItrackContext());
                _BundleHeaderRepository.Add(AssignBundleHeader());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }




        private Int64 GetBundleHeaderID() {
            try {
                GenaricRepository<BundleHeader> _BundleHeaderRepository = new GenaricRepository<BundleHeader>(new ItrackContext());
                return  _BundleHeaderRepository.GetAll().ToList().Last().BundleHeaderID;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return 0;
            }
        }










        BundleHeader _BundleHeader = new BundleHeader();


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        BundleHeader AssignBundleHeader()
        {
            try
            {


                _BundleHeader.BundleTagGenaratedBy = "None";
                _BundleHeader.BundleTagGenaratedTime = "None";
                _BundleHeader.isBundleTagsGerated = false;
                _BundleHeader.isOprationTagGenated = false;
                _BundleHeader.OprationTagGenaratedTime = "None";
                _BundleHeader.OprationTagGeratedBy = "None";
                _BundleHeader.CuttingItemID =Convert.ToInt16(gridView2.GetFocusedRowCellValue("CuttingItemID").ToString()); 
              


                return _BundleHeader;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            }
        }



        private void GenarateTags() {
            try {
                Cursor.Current = Cursors.WaitCursor;
                _cuttingHeader.CuttingHeaderID = txtCuttingTicketNo.Text;
                GenareteTags();
                GenarateTags gen = new GenarateTags();
                Int64 bundlehader = GetBundleHeaderID();
                string _lineNo =   gridView2.GetFocusedRowCellValue("LineNo").ToString();
                string _StyleNo = txtStyleNo.Text;
               
                List<OprationBarcodes> lst = new List<OprationBarcodes>();
                
                gen.GenrateBundleTags(150, 20, 25, bundlehader,_StyleNo,_lineNo,lst);
               
                FeedCuttingItem(_cuttingHeader.CuttingHeaderID);
              
                


                //using sql bulk copy
                SqlBulkCopyHelper _helper = new SqlBulkCopyHelper();
                _helper.PerformBulkCopy(_helper.ConvertTagsToDatatable(lst));

                Debug.WriteLine(lst.Count + "Count Of Record");
                Cursor.Current = Cursors.Default;

            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }


        private bool GenarateOprationBarcode() {
            try {


                return true;
            }
            catch(Exception ex){
                return false;
            }
        }

        #endregion

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchCuttingHeader();
        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
           _cuttingHeader.CuttingHeaderID = gridView3.GetFocusedRowCellValue("CuttingHeaderID").ToString();
          getCuttingFeild(_cuttingHeader.CuttingHeaderID);
          FeedCuttingItem(_cuttingHeader.CuttingHeaderID);
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
       
            GenarateTags();

           // GenarateTags gn = new GenarateTags();
           // Cursor.Current = Cursors.WaitCursor;
            //gn.genarateTestData();
           // Cursor.Current = Cursors.Default;
            
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            
       //   gen.genarateBundle(150, 20, 20);
          
            
        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            frmPrintBarcode print = new frmPrintBarcode();
            print.ShowDialog();
        }

        private void frmBundlingMaster_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            btnClose.Show();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            GenaricRepository<OprationBarcodes> _OprationBarcodesRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
         var t  =  from item in _OprationBarcodesRepository.GetAll().ToList()  where item.BundleDetails.BundleHeader.CuttingItemID == 3 orderby item.OprationBarcodesID select item;
        Debug.WriteLine( t.Count());
        }
    }
}