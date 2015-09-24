namespace EFTesting.Reports
{
    partial class rptPoDiliveries
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.fieldColor = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCutQty = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDate = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPcs = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldPoNo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldSize = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldStyleNo = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 52F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1,
            this.xrPivotGrid1});
            this.ReportHeader.HeightF = 328.125F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 59.04169F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(420.8333F, 23F);
            this.xrLabel2.Text = "VOGUE TEX WELIGAMA";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(673.9583F, 46.95834F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "CUTTING STATUS REPORT";
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataSource = this.bindingSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldColor,
            this.fieldCutQty,
            this.fieldDate,
            this.fieldPcs,
            this.fieldPoNo,
            this.fieldSize,
            this.fieldStyleNo});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 140.625F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.OptionsPrint.FilterSeparatorBarPadding = 3;
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(1070F, 155.625F);
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 82.04168F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(420.8333F, 23F);
            this.xrLabel4.Text = "Tele - 0412240451 / 0412240452          Email - Info@voguetex.com";
            // 
            // fieldColor
            // 
            this.fieldColor.AreaIndex = 0;
            this.fieldColor.FieldName = "Color";
            this.fieldColor.Name = "fieldColor";
            this.fieldColor.Width = 45;
            // 
            // fieldCutQty
            // 
            this.fieldCutQty.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldCutQty.AreaIndex = 1;
            this.fieldCutQty.FieldName = "CutQty";
            this.fieldCutQty.Name = "fieldCutQty";
            this.fieldCutQty.Width = 45;
            // 
            // fieldDate
            // 
            this.fieldDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDate.AreaIndex = 0;
            this.fieldDate.FieldName = "Date";
            this.fieldDate.Name = "fieldDate";
            this.fieldDate.ValueFormat.FormatString = "d";
            this.fieldDate.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldPcs
            // 
            this.fieldPcs.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPcs.AreaIndex = 0;
            this.fieldPcs.FieldName = "Pcs";
            this.fieldPcs.Name = "fieldPcs";
            this.fieldPcs.Width = 45;
            // 
            // fieldPoNo
            // 
            this.fieldPoNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPoNo.AreaIndex = 2;
            this.fieldPoNo.FieldName = "PoNo";
            this.fieldPoNo.Name = "fieldPoNo";
            this.fieldPoNo.Width = 45;
            // 
            // fieldSize
            // 
            this.fieldSize.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSize.AreaIndex = 0;
            this.fieldSize.FieldName = "Size";
            this.fieldSize.Name = "fieldSize";
            this.fieldSize.Width = 45;
            // 
            // fieldStyleNo
            // 
            this.fieldStyleNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldStyleNo.AreaIndex = 1;
            this.fieldStyleNo.FieldName = "StyleNo";
            this.fieldStyleNo.Name = "fieldStyleNo";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(EFTesting.ViewModel.PoDeliveries);
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 117.625F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(420.8333F, 23F);
            this.xrLabel3.Text = "SHIPMENT DATE VS CUT QTY ORDERED BY PO";
            // 
            // rptPoDiliveries
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataSource = this.bindingSource1;
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(64, 35, 52, 100);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "14.1";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.rptPoDiliveries_BeforePrint);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldColor;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCutQty;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDate;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPcs;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldPoNo;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldSize;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldStyleNo;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
    }
}
