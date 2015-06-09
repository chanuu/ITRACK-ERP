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

namespace EFTesting.UI
{
    public partial class frmDividingPlanItem : DevExpress.XtraEditors.XtraForm
    {
        public frmDividingPlanItem()
        {
            InitializeComponent();
        }

        public int DividingPlanID { get; set; }
        public string  OprationNo { get; set; }

        public string OprationName { get; set; }

        public string  SMVType { get; set; }

        public string MachineType { get; set; }

        public double SMV { get; set; }

        public int DividingPlanItemID { get; set; }

        public string  DividingPlanHeaderID { get; set; }


        public frmDividingPlanItem(int _divdinPlanHeader) {

            this.DividingPlanID = _divdinPlanHeader;
            InitializeComponent();
        }

        public frmDividingPlanItem(int _dPlanId,string _oprationNo, string _oprationName,string _smvType,string _machineType,double _smv,string _dHeaderID) {
            this.DividingPlanID = _dPlanId;
            this.OprationNo = _oprationNo;
            this.OprationName = _oprationName;
            this.SMVType = _smvType;
            this.MachineType = _machineType;
            this.SMV = _smv;
            this.DividingPlanHeaderID = _dHeaderID;
           
            InitializeComponent();
        }



        GenaricRepository<DividingPlanItem> _pDidingItemEditRepository = new GenaricRepository<DividingPlanItem>(new ItrackContext());
        GenaricRepository<DividingPlanItem> _pDidingItemRepository = new GenaricRepository<DividingPlanItem>(new ItrackContext());
      
        #region CRUD 

        DividingPlanItem AssignValues()
        {
            try {
                 DividingPlanItem _item = new DividingPlanItem();
                _item.DividingPlanHeaderID =Convert.ToInt16(this.DividingPlanHeaderID);
                _item.DividingPlanItemID = this.DividingPlanID;
                _item.OprationNo = txtOprationNo.Text;
                _item.OprationName = txtoprationName.Text;
                _item.MachineType = cmbMachineType.Text;
                _item.SMVType = cmbSmvType.Text;
                _item.SMV =Convert.ToDouble( txtSMV.Text);

                return _item;
            }
            catch (Exception ex) {
                return null;
            }
        
        }


        private bool AddItem() {
            try {
             
                _pDidingItemRepository.Add(AssignValues());
                return true;
            }
            catch(Exception ex){
                return false;
            }
        }


        private bool UpdateItem()
        {
            try
            {
              
                _pDidingItemEditRepository.Edit(AssignValues());
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void frmDividingPlanItem_Load(object sender, EventArgs e)
        {
            txtOprationNo.Text = this.OprationNo;
            txtoprationName.Text = this.OprationName;
            cmbMachineType.Text = this.MachineType;
            cmbSmvType.Text = this.SMVType;
            txtSMV.Text =Convert.ToString(this.SMV);
            btnAdd.Enabled = false;
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateItem();
            this.Close();
        }
    }
}