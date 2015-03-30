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
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class EmployeeMaster : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeMaster()
        {
            InitializeComponent();
        }

        #region Declarattion

        Validator Validator = new Validator();

        #endregion

        #region valitation
        public bool isValidEmployeeMaster()
        {


            if (!Validator.isPresent(txtEmployeeID, "Employee ID"))
            {
                return false;
            }

            if (!Validator.isPresent(txtFullName, "Full Name"))
            {
                return false;
            }

            if (!Validator.isPresent(txtDateOfBirth, "Date Of Birth"))
            {
                return false;
            }

            if (!Validator.isPresent(txtNIC, "NIC No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtEPFNo, "EPF No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtETFNo, "ETF No"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbDepartment, "Department"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbDesignation, "Designation"))
            {
                return false;
            }

            if (!Validator.isPresent(cmbJobStatus, "Job Status"))
            {
                return false;
            }

            if (!Validator.isPresent(rdoMeritalStatus, "Merital Status"))
            {
                return false;
            }

            if (!Validator.isPresent(rdoGender, "Gender"))
            {
                return false;
            }

            if (!Validator.isPresent(txtEmail, "E-mail Address"))
            {
                return false;
            }

            if (!Validator.isPresent(txtMobileNo, "Mobile No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtEmgNo, "Emergency No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtEmgContactPerson, "Emergency Contact Person"))
            {
                return false;
            }

            return true;
        }

        #endregion

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeMaster_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            frmPromotion promotion = new frmPromotion();
            promotion.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            frmAward award = new frmAward();
            award.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidEmployeeMaster() == true)
                AddEmployee();
        }

        private void AddEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
