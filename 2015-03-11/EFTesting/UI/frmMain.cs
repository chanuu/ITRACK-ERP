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
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;

namespace EFTesting.UI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DevExpress.UserSkins.TouchSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();

            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            var gallery = new DevExpress.XtraBars.Ribbon.GalleryDropDown();
            gallery.Manager = barManager1;
            SkinHelper.InitSkinGalleryDropDown(gallery);
            gallery.ShowPopup(MousePosition);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.frmCompany objfrmMChild = new UI.frmCompany();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.frmBuyer objfrmMChild = new UI.frmBuyer();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.frmStyleMaster objfrmMChild = new UI.frmStyleMaster();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            UI.frmPurchaseOrder objfrmMChild = new UI.frmPurchaseOrder();
            objfrmMChild.MdiParent = this;
            objfrmMChild.Show();
        }
    }
}