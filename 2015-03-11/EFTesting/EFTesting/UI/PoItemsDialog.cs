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
using EFTesting.ViewModel;
using ITRACK.models;

namespace EFTesting.UI
{
    public partial class PoItemsDialog : DevExpress.XtraEditors.XtraForm
    {
        public PoItemsDialog()
        {
            InitializeComponent();
        }

        PurchaseHeaderVM Pvm = new PurchaseHeaderVM();
        GenaricRepository<PurchaseOrderItems> _PORepository = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());
        PurchaseOrderItems _PoItem = new PurchaseOrderItems();


        private PurchaseOrderItems AssignPoItems() {
            try {
                PurchaseOrderItems _PoItems = new PurchaseOrderItems();
                _PoItems.PurchaseOrderID = txtPoNo.Text;
                _PoItems.Color = txtColorCode.Text;
                _PoItems.Size = txtSize.Text;
                _PoItems.Length = txtLength.Text;
                _PoItems.Quantity = Convert.ToInt16(txtQuntity.Text);
                _PoItems.PurchaseOrderHeaderID = _PoItems.PurchaseOrderID;
                return _PoItems;
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        
        }

        private void AddPOItems()
        {
            try
            {

                _PORepository.Add(AssignPoItems());
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #region CRUD

        private void SearchPo()
        {
            try
            {
                Pvm.SearchPoWithoutClose(grdSearchPo, txtPoNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion



        private void txtPoNo_EditValueChanged(object sender, EventArgs e)
        {
            SearchPo();
        }

        private void txtPoNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchPo.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchPo.Hide();

            }
        }

        private void grdSearchPo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPoNo.Text = gridView2.GetFocusedRowCellValue("PurchaseOrderHeaderID").ToString();
                grdSearchPo.Hide();
            
            }
        }

        private void PoItemsDialog_Load(object sender, EventArgs e)
        {
            grdSearchPo.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPOItems();
        }
    }
}