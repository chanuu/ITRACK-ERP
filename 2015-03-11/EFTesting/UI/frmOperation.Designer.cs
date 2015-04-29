namespace EFTesting.UI
{
    partial class frmOperation
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
            this.label9 = new System.Windows.Forms.Label();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtOperationName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSMVType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtSMV = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.grdSearch = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOperationCode = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSMVType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperationCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::EFTesting.Properties.Resources.update;
            this.btnDelete.Location = new System.Drawing.Point(300, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 39);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::EFTesting.Properties.Resources.save1;
            this.btnClose.Location = new System.Drawing.Point(777, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 38);
            this.btnClose.TabIndex = 39;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.EditValue = "";
            this.txtSearchBox.Location = new System.Drawing.Point(486, 23);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Properties.AccessibleDescription = "";
            this.txtSearchBox.Properties.NullText = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.txtSearchBox.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearchBox.Size = new System.Drawing.Size(285, 20);
            this.txtSearchBox.TabIndex = 38;
            this.txtSearchBox.EditValueChanged += new System.EventHandler(this.txtSearchBox_EditValueChanged);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchBox_KeyDown);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::EFTesting.Properties.Resources.update;
            this.simpleButton1.Location = new System.Drawing.Point(390, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 39);
            this.simpleButton1.TabIndex = 37;
            this.simpleButton1.Text = "Search";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::EFTesting.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(209, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 39);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Update";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::EFTesting.Properties.Resources.save1;
            this.btnAdd.Location = new System.Drawing.Point(117, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 39);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::EFTesting.Properties.Resources.save;
            this.btnNew.Location = new System.Drawing.Point(26, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 39);
            this.btnNew.TabIndex = 40;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(678, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Last Modified";
            // 
            // textEdit7
            // 
            this.textEdit7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit7.EditValue = "";
            this.textEdit7.Location = new System.Drawing.Point(753, 477);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.AccessibleDescription = "";
            this.textEdit7.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit7.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit7.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit7.Size = new System.Drawing.Size(209, 20);
            this.textEdit7.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Created By";
            // 
            // textEdit6
            // 
            this.textEdit6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit6.EditValue = "";
            this.textEdit6.Location = new System.Drawing.Point(456, 477);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.AccessibleDescription = "";
            this.textEdit6.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit6.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit6.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit6.Size = new System.Drawing.Size(209, 20);
            this.textEdit6.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Created Date";
            // 
            // textEdit5
            // 
            this.textEdit5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textEdit5.EditValue = "";
            this.textEdit5.Location = new System.Drawing.Point(182, 477);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.AccessibleDescription = "";
            this.textEdit5.Properties.NullText = "Please Enter Buyer Name";
            this.textEdit5.Properties.NullValuePrompt = "Please Enter Buyer Name";
            this.textEdit5.Properties.NullValuePromptShowForEmptyValue = true;
            this.textEdit5.Size = new System.Drawing.Size(188, 20);
            this.textEdit5.TabIndex = 50;
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.txtOperationCode);
            this.xtraTabPage1.Controls.Add(this.label10);
            this.xtraTabPage1.Controls.Add(this.txtSMV);
            this.xtraTabPage1.Controls.Add(this.cmbSMVType);
            this.xtraTabPage1.Controls.Add(this.label6);
            this.xtraTabPage1.Controls.Add(this.txtRemark);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.txtOperationName);
            this.xtraTabPage1.Image = global::EFTesting.Properties.Resources.Folder_Accept_icon;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(950, 395);
            this.xtraTabPage1.Text = "Header";
            // 
            // txtOperationName
            // 
            this.txtOperationName.EditValue = "";
            this.txtOperationName.Location = new System.Drawing.Point(198, 87);
            this.txtOperationName.Name = "txtOperationName";
            this.txtOperationName.Properties.AccessibleDescription = "";
            this.txtOperationName.Properties.NullValuePrompt = "Please Enter Style No";
            this.txtOperationName.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtOperationName.Size = new System.Drawing.Size(251, 20);
            this.txtOperationName.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Operation Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Remark";
            // 
            // txtRemark
            // 
            this.txtRemark.EditValue = "";
            this.txtRemark.Location = new System.Drawing.Point(198, 202);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.NullText = "Shipping Address";
            this.txtRemark.Properties.NullValuePrompt = "Shipping Address";
            this.txtRemark.Size = new System.Drawing.Size(289, 96);
            this.txtRemark.TabIndex = 35;
            this.txtRemark.UseOptimizedRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "SMV Type";
            // 
            // cmbSMVType
            // 
            this.cmbSMVType.Location = new System.Drawing.Point(198, 162);
            this.cmbSMVType.Name = "cmbSMVType";
            this.cmbSMVType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbSMVType.Properties.Items.AddRange(new object[] {
            "Pant",
            "Blouse",
            "Skirt"});
            this.cmbSMVType.Properties.NullValuePrompt = "Select Status";
            this.cmbSMVType.Properties.NullValuePromptShowForEmptyValue = true;
            this.cmbSMVType.Size = new System.Drawing.Size(212, 20);
            this.cmbSMVType.TabIndex = 38;
            // 
            // txtSMV
            // 
            this.txtSMV.EditValue = "";
            this.txtSMV.Location = new System.Drawing.Point(198, 122);
            this.txtSMV.Name = "txtSMV";
            this.txtSMV.Properties.AccessibleDescription = "";
            this.txtSMV.Properties.NullValuePrompt = "Please Enter Style No";
            this.txtSMV.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSMV.Size = new System.Drawing.Size(251, 20);
            this.txtSMV.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(80, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "SMV";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabControl1.Location = new System.Drawing.Point(22, 70);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1032, 401);
            this.xtraTabControl1.TabIndex = 27;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // grdSearch
            // 
            this.grdSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSearch.Location = new System.Drawing.Point(22, 57);
            this.grdSearch.MainView = this.gridView2;
            this.grdSearch.Name = "grdSearch";
            this.grdSearch.Size = new System.Drawing.Size(971, 341);
            this.grdSearch.TabIndex = 56;
            this.grdSearch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.grdSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSearch_KeyDown);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grdSearch;
            this.gridView2.Name = "gridView2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Operation Code";
            // 
            // txtOperationCode
            // 
            this.txtOperationCode.EditValue = "";
            this.txtOperationCode.Location = new System.Drawing.Point(198, 53);
            this.txtOperationCode.Name = "txtOperationCode";
            this.txtOperationCode.Properties.AccessibleDescription = "";
            this.txtOperationCode.Properties.NullValuePrompt = "Please Enter Style No";
            this.txtOperationCode.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtOperationCode.Size = new System.Drawing.Size(251, 20);
            this.txtOperationCode.TabIndex = 41;
            // 
            // frmOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 525);
            this.Controls.Add(this.grdSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEdit6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textEdit5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmOperation";
            this.Text = "Operation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSMVType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOperationCode.Properties)).EndInit();
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
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtSMV;
        private DevExpress.XtraEditors.ComboBoxEdit cmbSMVType;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtOperationName;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraGrid.GridControl grdSearch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtOperationCode;
    }
}