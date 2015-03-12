namespace EFTesting.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.skinBar = new DevExpress.XtraBars.SkinBarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.skinBar1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.gallery = new DevExpress.XtraBars.BarSubItem();
            this.skinBar2 = new DevExpress.XtraBars.SkinBarSubItem();
            this.masterfile = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.masters = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.config = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.reports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBar,
            this.barButtonItem1,
            this.barSubItem1,
            this.skinBar1,
            this.gallery,
            this.barButtonItem2,
            this.barSubItem2,
            this.skinBar2,
            this.barButtonItem4});
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Select Skin";
            this.barSubItem2.Id = 6;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Skin Gallery";
            this.barButtonItem4.Id = 8;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(864, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 390);
            this.barDockControlBottom.Size = new System.Drawing.Size(864, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 390);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(864, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 390);
            // 
            // skinBar
            // 
            this.skinBar.Caption = "skinBarSubItem1";
            this.skinBar.Id = 0;
            this.skinBar.Name = "skinBar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 2;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBar1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // skinBar1
            // 
            this.skinBar1.Caption = "SkinSelect";
            this.skinBar1.Id = 3;
            this.skinBar1.Name = "skinBar1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Gallery";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // gallery
            // 
            this.gallery.Caption = "gallery";
            this.gallery.Id = 4;
            this.gallery.Name = "gallery";
            // 
            // skinBar2
            // 
            this.skinBar2.Caption = "Skins";
            this.skinBar2.Id = 7;
            this.skinBar2.Name = "skinBar2";
            // 
            // masterfile
            // 
            this.masterfile.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.masterfile.Name = "masterfile";
            this.masterfile.Text = "Master Files ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = -1;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.masters,
            this.config,
            this.reports});
            this.ribbonControl1.Size = new System.Drawing.Size(864, 142);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Style Master";
            this.barButtonItem5.Glyph = global::EFTesting.Properties.Resources.barcode_folded_icon;
            this.barButtonItem5.Id = 1;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Cutting Master";
            this.barButtonItem6.Glyph = global::EFTesting.Properties.Resources.Clipboard_Plan_icon;
            this.barButtonItem6.Id = 2;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Workflow";
            this.barButtonItem7.Glyph = global::EFTesting.Properties.Resources.share_folded_icon;
            this.barButtonItem7.Id = 3;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Sketch Master";
            this.barButtonItem8.Glyph = global::EFTesting.Properties.Resources.VideoBlend_icon;
            this.barButtonItem8.Id = 4;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Company Setup";
            this.barButtonItem9.Glyph = global::EFTesting.Properties.Resources.home_folded_icon;
            this.barButtonItem9.Id = 5;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Users Setup";
            this.barButtonItem10.Glyph = global::EFTesting.Properties.Resources.check_contact_folded_icon;
            this.barButtonItem10.Id = 6;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // masters
            // 
            this.masters.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.masters.Name = "masters";
            this.masters.Text = "Master Files ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // config
            // 
            this.config.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.config.Name = "config";
            this.config.Text = "Configurations";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // reports
            // 
            this.reports.Name = "reports";
            this.reports.Text = "Reports";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 415);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "ITRACK ERP - HOME ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.SkinBarSubItem skinBar;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBar1;
        private DevExpress.XtraBars.BarSubItem gallery;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.SkinBarSubItem skinBar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage masterfile;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage masters;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPage config;
        private DevExpress.XtraBars.Ribbon.RibbonPage reports;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
    }
}