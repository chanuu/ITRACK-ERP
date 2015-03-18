namespace EFTesting.UI
{
    partial class frmStyleMaster
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
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchBox = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grdSearchBuyer = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbGarmentType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeason = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArticle = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuyerName = new DevExpress.XtraEditors.TextEdit();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStyleNo = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.grdSearchStyle = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchBuyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGarmentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::EFTesting.Properties.Resources.update;
            this.btnDelete.Location = new System.Drawing.Point(290, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::EFTesting.Properties.Resources.save1;
            this.btnClose.Location = new System.Drawing.Point(767, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 38);
            this.btnClose.TabIndex = 22;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.EditValue = "";
            this.txtSearchBox.Location = new System.Drawing.Point(476, 23);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Properties.AccessibleDescription = "";
            this.txtSearchBox.Properties.NullText = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearchBox.Size = new System.Drawing.Size(285, 20);
            this.txtSearchBox.TabIndex = 22;
            this.txtSearchBox.EditValueChanged += new System.EventHandler(this.txtSearchBox_EditValueChanged);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton1.Location = new System.Drawing.Point(380, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(199, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(107, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(16, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 17;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 80);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1173, 407);
            this.xtraTabControl1.TabIndex = 24;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grdSearchBuyer);
            this.xtraTabPage1.Controls.Add(this.cmbStatus);
            this.xtraTabPage1.Controls.Add(this.cmbGarmentType);
            this.xtraTabPage1.Controls.Add(this.label10);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.label5);
            this.xtraTabPage1.Controls.Add(this.txtSeason);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.txtArticle);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtBuyerName);
            this.xtraTabPage1.Controls.Add(this.txtRemark);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.txtStyleNo);
            this.xtraTabPage1.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1091, 401);
            this.xtraTabPage1.Text = "Header";
            // 
            // grdSearchBuyer
            // 
            this.grdSearchBuyer.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearchBuyer.Location = new System.Drawing.Point(177, 99);
            this.grdSearchBuyer.MainView = this.gridView1;
            this.grdSearchBuyer.Name = "grdSearchBuyer";
            this.grdSearchBuyer.Size = new System.Drawing.Size(741, 195);
            this.grdSearchBuyer.TabIndex = 35;
            this.grdSearchBuyer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdSearchBuyer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearchBuyer_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdSearchBuyer;
            this.gridView1.Name = "gridView1";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Location = new System.Drawing.Point(629, 36);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbStatus.Properties.Items.AddRange(new object[] {
            "Pending ",
            "Complted"});
            this.cmbStatus.Size = new System.Drawing.Size(199, 20);
            this.cmbStatus.TabIndex = 34;
            // 
            // cmbGarmentType
            // 
            this.cmbGarmentType.Location = new System.Drawing.Point(177, 201);
            this.cmbGarmentType.Name = "cmbGarmentType";
            this.cmbGarmentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGarmentType.Properties.Items.AddRange(new object[] {
            "Pant ",
            "Blouse"});
            this.cmbGarmentType.Size = new System.Drawing.Size(199, 20);
            this.cmbGarmentType.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(511, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Status ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Garment Type ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Season";
            // 
            // txtSeason
            // 
            this.txtSeason.EditValue = "";
            this.txtSeason.Location = new System.Drawing.Point(177, 156);
            this.txtSeason.Name = "txtSeason";
            this.txtSeason.Properties.AccessibleDescription = "";
            this.txtSeason.Properties.NullText = "Please Enter Buyer Name";
            this.txtSeason.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtSeason.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSeason.Size = new System.Drawing.Size(251, 20);
            this.txtSeason.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Article ";
            // 
            // txtArticle
            // 
            this.txtArticle.EditValue = "";
            this.txtArticle.Location = new System.Drawing.Point(177, 116);
            this.txtArticle.Name = "txtArticle";
            this.txtArticle.Properties.AccessibleDescription = "";
            this.txtArticle.Properties.NullText = "Please Enter Buyer Name";
            this.txtArticle.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtArticle.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtArticle.Size = new System.Drawing.Size(251, 20);
            this.txtArticle.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Buyer Name";
            // 
            // txtBuyerName
            // 
            this.txtBuyerName.EditValue = "";
            this.txtBuyerName.Location = new System.Drawing.Point(177, 73);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Properties.AccessibleDescription = "";
            this.txtBuyerName.Properties.NullText = "Please Enter Buyer Name";
            this.txtBuyerName.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtBuyerName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtBuyerName.Size = new System.Drawing.Size(251, 20);
            this.txtBuyerName.TabIndex = 24;
            this.txtBuyerName.EditValueChanged += new System.EventHandler(this.txtBuyerName_EditValueChanged);
            this.txtBuyerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuyerName_KeyDown);
            // 
            // txtRemark
            // 
            this.txtRemark.EditValue = "";
            this.txtRemark.Location = new System.Drawing.Point(629, 76);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.NullText = "Shipping Address";
            this.txtRemark.Properties.NullValuePrompt = "Shipping Address";
            this.txtRemark.Size = new System.Drawing.Size(289, 96);
            this.txtRemark.TabIndex = 23;
            this.txtRemark.UseOptimizedRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Remark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Style No";
            // 
            // txtStyleNo
            // 
            this.txtStyleNo.EditValue = "";
            this.txtStyleNo.Location = new System.Drawing.Point(177, 36);
            this.txtStyleNo.Name = "txtStyleNo";
            this.txtStyleNo.Properties.AccessibleDescription = "";
            this.txtStyleNo.Properties.NullText = "Please Enter Buyer Name";
            this.txtStyleNo.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtStyleNo.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtStyleNo.Size = new System.Drawing.Size(251, 20);
            this.txtStyleNo.TabIndex = 12;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1091, 401);
            this.xtraTabPage2.Text = "PO";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1091, 401);
            this.xtraTabPage3.Text = "WIP";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Created Date";
            // 
            // textEdit5
            // 
            this.textEdit5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit5.EditValue = "";
            this.textEdit5.Location = new System.Drawing.Point(169, 494);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.AccessibleDescription = "";
            this.textEdit5.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit5.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit5.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit5.Size = new System.Drawing.Size(188, 20);
            this.textEdit5.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Created By";
            // 
            // textEdit6
            // 
            this.textEdit6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit6.EditValue = "";
            this.textEdit6.Location = new System.Drawing.Point(443, 494);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.AccessibleDescription = "";
            this.textEdit6.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit6.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit6.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit6.Size = new System.Drawing.Size(209, 20);
            this.textEdit6.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(665, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Last Modified";
            // 
            // textEdit7
            // 
            this.textEdit7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit7.EditValue = "";
            this.textEdit7.Location = new System.Drawing.Point(740, 494);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.AccessibleDescription = "";
            this.textEdit7.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit7.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit7.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit7.Size = new System.Drawing.Size(209, 20);
            this.textEdit7.TabIndex = 36;
            // 
            // grdSearchStyle
            // 
            this.grdSearchStyle.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearchStyle.Location = new System.Drawing.Point(12, 57);
            this.grdSearchStyle.MainView = this.gridView2;
            this.grdSearchStyle.Name = "grdSearchStyle";
            this.grdSearchStyle.Size = new System.Drawing.Size(1108, 328);
            this.grdSearchStyle.TabIndex = 38;
            this.grdSearchStyle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grdSearchStyle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearchStyle_KeyDown);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdSearchStyle;
            this.gridView2.Name = "gridView2";
            // 
            // frmStyleMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 523);
            this.Controls.Add(this.grdSearchStyle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Name = "frmStyleMaster";
            this.Text = "Style Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStyleMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchBuyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGarmentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArticle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuyerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStyleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtSearchBox;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtStyleNo;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtArticle;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtBuyerName;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtSeason;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit cmbStatus;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGarmentType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraGrid.GridControl grdSearchBuyer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdSearchStyle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}