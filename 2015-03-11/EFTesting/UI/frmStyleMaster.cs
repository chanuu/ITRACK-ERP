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
using System.Linq.Expressions;
using System.Diagnostics;

namespace EFTesting.UI
{
    public partial class frmStyleMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmStyleMaster()
        {
            InitializeComponent();
        }

        #region  Delcaration
            GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
            GenaricRepository<Buyer> _BuyerRepository = new GenaricRepository<Buyer>(new ItrackContext());
            GenaricRepository<Style> _Stylerepository = new GenaricRepository<Style>(new ItrackContext());
            Buyer _Buyer = new Buyer();
            Company _Company = new Company();
            Style _Style = new Style();
            StyleVM _StyleVM = new StyleVM();

           
        
        #endregion



        #region CRUD


            void Clear() {
                try {
                    txtStyleNo.Text = "";
                    txtArticle.Text = "";
                    txtSeason.Text = "";
                    txtRemark.Text = "";
                    txtBuyerName.Text = "";
                    cmbGarmentType.Text = "";
                    cmbStatus.Text = "";
                    txtStyleNo.Focus();
                    grdSearchBuyer.Hide();
                    btnClose.Hide();
                 

                }
                catch(Exception ex){
                    Debug.WriteLine(ex.Message);
                }
            
            }
        Style AssignStyle() {
            try {
                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _Company.CompanyID = item.CompanyID;

                }
                _Style.StyleID = txtStyleNo.Text;
                _Style.Article = txtArticle.Text;
                _Style.Season = txtSeason.Text;
                _Style.CompanyID = _Company.CompanyID;
                _Style.Remark = txtRemark.Text;
                _Style.Status = cmbStatus.Text; 
                _Style.BuyerID = _Buyer.BuyerID;
                _Style.GarmantType = cmbGarmentType.Text;
               

                return _Style;
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        
        }

        private void SearchBuyer()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(Buyer), "s");
                Expression nameProperty = Expression.Property(argParam, "BuyerName");
                Expression namespaceProperty = Expression.Property(argParam, "BuyerName");

                var val1 = Expression.Constant(txtBuyerName.Text);
                var val2 = Expression.Constant(txtBuyerName.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<Buyer, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _BuyerRepository.SearchFor(lambda1).ToList() select new { item.BuyerID, item.BuyerName, item.BuyerTeleNo, item.FaxNo, item.BuyerShippingAddress };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchBuyer.Show();
                    btnClose.Show();

                    grdSearchBuyer.DataSource = selected;
                }
                else
                {
                    grdSearchBuyer.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void SearchStyle() {
            try {
                _StyleVM.SearchBuyer(grdSearchStyle, txtSearchBox, btnClose);
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void AddStyle()
        {
            try
            {
                _Stylerepository.Add(AssignStyle());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        async void editStyle()
        {


            try
            {
                GenaricRepository<Style> _genaricrepositoryStylenew = new GenaricRepository<Style>(new ItrackContext());
                await _genaricrepositoryStylenew.EditAsync(AssignStyle());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void getStyleFeild(string ID)
        {
            try
            {

                foreach (var style in GetStyleByID(ID))
                {
                    txtStyleNo.Text = style.StyleID;
                    txtBuyerName.Text = style.Buyer.BuyerName;
                    txtArticle.Text = style.Article;
                    cmbStatus.Text = style.Status;
                    cmbGarmentType.Text = style.GarmantType;
                    txtRemark.Text = style.Remark;
                    _Company.CompanyID = style.CompanyID;
                    txtSeason.Text = style.Season;
                    _Buyer = style.Buyer;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Style> GetStyleByID(string ID)
        {
            try
            {
                return _Stylerepository.GetAll().Where(u => u.StyleID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }
        #endregion

        #region Events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStyle();
        }

        private void txtBuyerName_EditValueChanged(object sender, EventArgs e)
        {
            SearchBuyer();
        }

        private void txtBuyerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchBuyer.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchBuyer.Hide();

            }
        }

        private void grdSearchBuyer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _Buyer.BuyerID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("BuyerID").ToString());
                _Buyer.BuyerName = gridView1.GetFocusedRowCellValue("BuyerName").ToString();
                txtBuyerName.Text = _Buyer.BuyerName;
                grdSearchBuyer.Hide();
            }



        }

        private void frmStyleMaster_Load(object sender, EventArgs e)
        {
            grdSearchBuyer.Hide();
            grdSearchStyle.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchStyle();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchStyle.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchStyle.Hide();

            }
        }

        private void grdSearchStyle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _Style.StyleID = gridView2.GetFocusedRowCellValue("StyleID").ToString();
                getStyleFeild(_Style.StyleID);
                grdSearchStyle.Hide();
                btnClose.Hide();
                txtSearchBox.Hide();
                grdSearchBuyer.Hide();
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearchStyle.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editStyle();
        }

        #endregion

    }
}