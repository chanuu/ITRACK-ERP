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
using EFTesting.ViewModel;
using EFTesting.Reports;
using DevExpress.XtraReports.UI;
using DevExpress.Office.Utils;

namespace EFTesting.UI
{
    public partial class frmPoDeliveriesDialog : DevExpress.XtraEditors.XtraForm
    {
        public frmPoDeliveriesDialog()
        {
            InitializeComponent();
        }


        List<PoDeliveries> lstPo = new List<PoDeliveries>();
        private List<PoDeliveries> GetReportData(DateTime _fromDate,DateTime _toDate)
        {

            try {
                GenaricRepository<PurchaseOrderItems> _PoRepo = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());
               
                foreach (var item in _PoRepo.GetAll().ToList()) {
                   
                    GenaricRepository<CuttingItem> _CutRepo = new GenaricRepository<CuttingItem>(new ItrackContext());
                   
                    var cut = from x in _CutRepo.GetAll()
                              where x.Size == item.Size && x.Color == item.Color && x.PoNo == item.PurchaseOrderID
                              select x;
                    int cutQty =0;
                    if (cut.Count() > 0)
                    {

                        foreach (var i in cut) {

                            cutQty = i.NoOfItem + cutQty;
                        }
                        
                       
                    }
                    
                    

                   
                    lstPo.Add(new PoDeliveries { 
                        Date= item.PurchaseOrderHeader.EndDate,
                        PoNo = item.PurchaseOrderID,
                        StyleNo= item.PurchaseOrderHeader.StyleID,
                        Color=item.Color,
                        Size=item.Size,
                        Pcs= item.Quantity,
                        CutQty = cutQty
                    });

                    cutQty = 0;
                
                }
                Debug.WriteLine("No Of rows" + lstPo.Count);
                return lstPo;

            }
            catch(Exception){
                return lstPo;
            }
        
        }



        private void GenarateReport() {

            try {

                rptPoDiliveries report = new rptPoDiliveries();
                report.DataSource = GetReportData(Convert.ToDateTime( txtFromDate.Text),Convert.ToDateTime(txttoDate.Text) );
                report.Landscape = true;
                ReportPrintTool tool = new ReportPrintTool(report);

                tool.ShowPreview();
            
            }
            catch(Exception ex){
            
            }
        
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            GenarateReport();
        }
    }
}