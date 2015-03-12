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
    public partial class frmCompany : DevExpress.XtraEditors.XtraForm
    {
        public frmCompany()
        {
            InitializeComponent();
        }
        GenaricRepository<Group> _genaricrepository = new GenaricRepository<Group>(new ItrackContext());
      #region GROUP CRUD


        //assign group properties and return new group object 
        private Group AssignGroup() {
            Group _group = new Group();
            _group.GroupID = txtGroupID.Text;
            _group.GroupName = txtGroupName.Text;
            _group.TeleNo = txtTeleNo.Text;
            _group.FaxNo = txtFaxNo.Text;
            _group.Address = txtAddress.Text;
            return _group;
        } 

        //add vew group to database 
      private  void addGroup() {

          try {
             
              _genaricrepository.Add(AssignGroup());
              
          }
          catch(Exception ex){
              MessageBox.Show( ex.Message, "Error - C-0001", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

        }


        // edit existing group 
      private void EditGroup()
      {

          try
          {
              _genaricrepository.Edit(AssignGroup());

          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error - C-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

      }
        // get all group 
      private  void GetGroup()
      {
          try {

            var datasource =   from item in _genaricrepository.GetAll().ToList() select new { item.GroupID, item.GroupName, item.TeleNo, item.FaxNo, item.Address };
            grdGroup.DataSource = datasource;
          }
          catch(Exception ex){
              MessageBox.Show(ex.Message, "Error - C-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      
      }

      private List<Group> GetGroupByID(string ID)
      {
          try
          {
             return _genaricrepository.GetAll().Where(u => u.GroupID == ID).ToList();
             
             
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return null;
             
          }

      }

        // get selected object values to form controls 
      void getGroupFeild(string ID) {
          try {

              foreach (var groups in GetGroupByID(ID)) {
                  txtGroupID.Text = groups.GroupID;
                  txtGroupName.Text = groups.GroupName;
                  txtTeleNo.Text = groups.TeleNo;
                  txtFaxNo.Text = groups.FaxNo;
                  txtAddress.Text = groups.Address;
              }
          }
          catch(Exception ex){
              MessageBox.Show(ex.Message, "Error - C-0005", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }
        #endregion


      #region Evets 
        
      void maximixedRibbon() { }


      private void frmCompany_FormClosing(object sender, FormClosingEventArgs e)
      {

      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
          addGroup();
          GetGroup();
      }

      private void frmCompany_Load(object sender, EventArgs e)
      {
          GetGroup();

      }

      private void btnEdit_Click(object sender, EventArgs e)
      {
          if (btnEdit.Text == "Edit")
          {
              string groupID = gridView1.GetFocusedRowCellValue("GroupID").ToString();
              getGroupFeild(groupID);
              btnEdit.Text = "Update";
          }
          else
          {
              EditGroup();
              btnEdit.Text = "Edit";
          }


      }

      #endregion


    }
}