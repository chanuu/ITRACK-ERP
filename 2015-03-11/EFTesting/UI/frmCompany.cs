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

namespace EFTesting.UI
{
    public partial class frmCompany : DevExpress.XtraEditors.XtraForm
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        void maximixedRibbon() { }

        void MinimizidRibbon() {
            UI.frmMain main = new UI.frmMain();
            int openFormCount = Application.OpenForms.Cast<Form>()
            .Count(openForm => openForm.IsMdiChild);

            if (openFormCount > 0) { 
           
            
            }
        }
        private void frmCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}