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
using ITRACK.models;
using System.Diagnostics;
using System.Linq.Expressions;

namespace EFTesting.UI
{
    public partial class frmOperation : DevExpress.XtraEditors.XtraForm
    {
        public frmOperation()
        {
            InitializeComponent();
        }



        #region Initilization

        OperationPool _Operation = new OperationPool();
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        GenaricRepository<OperationPool> _OperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());
        GenaricRepository<Style> _StyleRepository = new GenaricRepository<Style>(new ItrackContext());
        GenaricRepository<OperationPool> _EditOperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());
        Company _Company = new Company();

        #endregion

        #region CRUD
        OperationPool AssignOperation()
        {
            try {
                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _Company.CompanyID = item.CompanyID;

                }
                _Operation.CompanyID = _Company.CompanyID;
                _Operation.OperationPoolID = txtOperationCode.Text;
                _Operation.OpationName = txtOperationName.Text;
                _Operation.SMV =Convert.ToDouble( txtSMV.Text);
                _Operation.SMVType = cmbSMVType.Text;
                _Operation.Remark = txtRemark.Text;
                return _Operation;
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
                return null;
            
            }
        }



        private void AddOpration()
        {
            try
            {
                _OperationRepository.Add(AssignOperation());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EditOperation()
        {
            try
            {
                _EditOperationRepository.Add(AssignOperation());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SearchSketch()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(OperationPool), "s");
                Expression nameProperty = Expression.Property(argParam, "OperationPoolID");
                Expression namespaceProperty = Expression.Property(argParam, "OpationName");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<OperationPool, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _OperationRepository.SearchFor(lambda1).ToList() select new { item.OperationPoolID,item.OpationName,item.SMV,item.SMVType };

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

                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        void getOperationFeild(string ID)
        {
            try
            {

                foreach (var operation in GetoprationByID(ID))
                {


                    txtOperationCode.Text = operation.OperationPoolID;
                    txtOperationName.Text = operation.OpationName;
                    txtSMV.Text =Convert.ToString( operation.SMV);
                    cmbSMVType.Text = operation.SMVType;
                    txtRemark.Text = operation.Remark;
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<OperationPool> GetoprationByID(string ID)
        {
            try
            {
                return _OperationRepository.GetAll().Where(u => u.OperationPoolID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }


        private void clear() {
            try {
                txtOperationCode.Text = "";
                txtOperationName.Text = "";
                txtSMV.Text = "";
                cmbSMVType.Text ="";
                txtRemark.Text = "";
                txtOperationCode.Focus();
                grdSearch.Hide();
            
            }catch(Exception ex){
            
            }
        
        }
        #endregion


        #region Validation
        #endregion



        private void frmOperation_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchSketch();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearch.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearch.Hide();
                txtSearchBox.Hide();
                btnClose.Hide();

            }
        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                _Operation.OperationPoolID = gridView2.GetFocusedRowCellValue("OperationPoolID").ToString();
                getOperationFeild(_Operation.OperationPoolID);
                grdSearch.Hide();
                txtSearchBox.Hide();
                btnClose.Hide();
            }
            
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddOpration();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditOperation();
        }
    }
}