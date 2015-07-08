using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.Reports
{
   public class clsProductionSummary
    {
        public string LineNo { get; set; }

        public string StyleNo { get; set; }

        public int LineInput { get; set; }

        public int LineOut { get; set; }

        public int CutQty { get; set; }

        public int WharehouseIn { get; set; }

        public int WharehouseOut { get; set; }

        public DateTime Date { get; set; }
    



      public  clsProductionSummary() { }

      public  clsProductionSummary(
            string _styleNo,
            string _lineNo,
            int _CutQty,
            int _LineIn,
            int _LineOut,
            
            int _WhIn,
            int _WhOut,
            DateTime _date

            
            ) {

                this.StyleNo = _styleNo;
                this.LineNo = _lineNo;
                this.LineInput = _LineIn;
                this.LineOut = _LineOut;
                this.CutQty = _CutQty;
                this.WharehouseIn = _WhIn;
                this.WharehouseOut = _WhOut;
                this.Date = _date;
        }


    List<clsProductionSummary> lstSummary = new List<clsProductionSummary>();
   //   clsProductionSummary _summary = new clsProductionSummary();
       public List<clsProductionSummary> GetInputCount()
       {
           try {

               GenaricRepository<OprationBarcodes> _BarcodeEditRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
               var itemList = from items in _BarcodeEditRepository.GetAll().ToList() where items.OprationRole == "In" && items.isOparationComplete == true group items by items.OprationComplteAt.Date into ItemG select new { Date = Convert.ToDateTime(ItemG.Key.ToString("dd-MM-yyyy")), Count = ItemG.Sum(c => c.BundleDetails.NoOfItem) };
               
               foreach (var item in itemList) {

                   
                   Debug.WriteLine("Date :" + item.Date + " Input: " + item.Count + "  " + " Out: " + GetOutPut(item.Date, "") + "" +"  Cut Out:"+ GetCutOut(item.Date, ""));

                   lstSummary.Add(new clsProductionSummary("By-Jk", "V-6", GetCutOut(item.Date, ""), Convert.ToInt16(item.Count), GetOutPut(item.Date, ""), 0, 0, item.Date));
               
               }
               return lstSummary;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return null;
               
           }
       
       }


       public void getSampleDate(){
        
         GenaricRepository<OprationBarcodes> _BarcodeEditRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
         var itemList = from items in _BarcodeEditRepository.GetAll().ToList() where items.OprationRole == "In"  select items ;
             Debug.WriteLine(itemList.Count());
       }



       public int GetOutPut(DateTime _date,string LineName)
       {
           try
           {

               GenaricRepository<OprationBarcodes> _BarcodeEditRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
               var itemList = from items in _BarcodeEditRepository.GetAll().ToList() where items.OprationRole == "Out" && items.isOparationComplete == true && _date.Day == items.OprationComplteAt.Day && _date.Month == items.OprationComplteAt.Month && _date.Year == items.OprationComplteAt.Year group items by items.OprationComplteAt.Date into ItemG select new { Date = ItemG.Key, OutPut = ItemG.Sum(c => c.BundleDetails.NoOfItem) };

               return Convert.ToInt16(itemList.Last().OutPut);
              
           }
           catch (Exception ex)
           {
               Debug.WriteLine(ex.Message);
               return 0;

           }

       }





       public int GetCutOut(DateTime _date, string LineName)
       {
           try
           {

               GenaricRepository<CuttingItem> _CuttingRepository = new GenaricRepository<CuttingItem>(new ItrackContext());
               var itemList = from items in _CuttingRepository.GetAll().ToList() where _date.Day == items.Date.Day && _date.Month == items.Date.Month && _date.Year == items.Date.Year group items by items.Date into ItemG select new { Date = ItemG.Key, OutPut = ItemG.Sum(c => c.NoOfItem) };

               return Convert.ToInt16(itemList.Last().OutPut);

           }
           catch (Exception ex)
           {
               Debug.WriteLine(ex.Message);
               return 0;

           }

       }


       
    }
}
