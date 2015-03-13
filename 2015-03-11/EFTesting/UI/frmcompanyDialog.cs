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

namespace EFTesting.UI
{
    public partial class frmcompanyDialog : DevExpress.XtraEditors.XtraForm
    {
        public frmcompanyDialog()
        {
            InitializeComponent();
        }
#region Inilization 
        GenaricRepository<Group> _genaricrepository = new GenaricRepository<Group>(new ItrackContext());
        GenaricRepository<Company> _genaricrepositorycompany = new GenaricRepository<Company>(new ItrackContext());
        Group _group = new Group();
#endregion


#region COMPANYCRUD



        void SerchGroup() {
            try {
              
               

                ParameterExpression argParam = Expression.Parameter(typeof(Group), "s");
                Expression nameProperty = Expression.Property(argParam, "GroupName");
                Expression namespaceProperty = Expression.Property(argParam, "GroupID");

                var val1 = Expression.Constant(txtGroupID.Text);
                var val2 = Expression.Constant(txtGroupID.Text);

                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                
                Expression e2 = Expression.Call(namespaceProperty,"Contains",null, val2);
                var andExp = Expression.Or(e1, e2);

                var lambda1 = Expression.Lambda<Func<Group, bool>>(andExp, argParam);
                
                var selected = from item in _genaricrepository.SearchFor(lambda1).ToList() select new { item.GroupID, item.GroupName, item.TeleNo, item.FaxNo, item.Address };
                if (selected.Count() > 0)
                {
                    grdGroup.DataSource = selected;
                }
                else {
                    grdGroup.DataSource = null;
                }

                






            }
            catch(Exception ex){
            
            }
        }


        #endregion




        private void frmcompanyDialog_Load(object sender, EventArgs e)
        {

        }

        private void txtGroupID_EditValueChanged(object sender, EventArgs e)
        {
            SerchGroup();
        }
    }
}