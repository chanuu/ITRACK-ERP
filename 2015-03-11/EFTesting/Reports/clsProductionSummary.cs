﻿using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                   
               //    Debug.WriteLine("Date :" + item.Date + " Input: " + item.Count + "  " + " Out: " + GetOutPut(item.Date, "") + "" +"  Cut Out:"+ GetCutOut(item.Date, ""));

                //   lstSummary.Add(new clsProductionSummary("By-Jk", "V-6", GetCutOut(item.Date, ""), Convert.ToInt16(item.Count), GetOutPut(item.Date, ""), 0, 0, item.Date));
               
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

    



       /// <summary>
       /// /day end process run . admin can run privoues day 
       /// </summary>
       /// <param name="dayendDate"></param>
      public static async Task<bool> GetProductionDaySummary(DateTime dayendDate)
       {

           try
           {
               GenaricRepository<OprationBarcodes> _OperationBarcode = new GenaricRepository<OprationBarcodes>(new ItrackContext());
               var itemList = from items in _OperationBarcode.GetAll().ToList()

                              where items.OprationRole == "In" && items.isOparationComplete == true && items.OprationComplteAt.Day == dayendDate.Day && items.OprationComplteAt.Month == dayendDate.Month && items.OprationComplteAt.Year == dayendDate.Year

                              group items by new { items.OprationComplteAt.Date, items.LineNo, items.StyleNo, items.BundleDetails.BundleHeader.CuttingItem.Color, items.BundleDetails.BundleHeader.CuttingItem.Size } into ItemG

                              select new { ItemG.Key.Date, ItemG.Key.LineNo, ItemG.Key.StyleNo, ItemG.Key.Color, ItemG.Key.Size, Count = ItemG.Sum(c => c.BundleDetails.NoOfItem) };


               var itemListOut = from items in _OperationBarcode.GetAll().ToList()

                              where items.OprationRole == "Out" && items.isOparationComplete == true && items.OprationComplteAt.Day == dayendDate.Day && items.OprationComplteAt.Month == dayendDate.Month && items.OprationComplteAt.Year == dayendDate.Year

                              group items by new { items.OprationComplteAt.Date, items.LineNo, items.StyleNo, items.BundleDetails.BundleHeader.CuttingItem.Color, items.BundleDetails.BundleHeader.CuttingItem.Size } into ItemG

                              select new { ItemG.Key.Date, ItemG.Key.LineNo, ItemG.Key.StyleNo, ItemG.Key.Color, ItemG.Key.Size, Count = ItemG.Sum(c => c.BundleDetails.NoOfItem) };

               
               
               
               foreach (var items in itemList)
               {
                   
                   Debug.WriteLine("Date :" + items.Date.Date + " Line No - " + items.LineNo + " Style No " + items.StyleNo + " Color -" + items.Color + " Size -" + items.Size +" Cut Qty -"+ GetCutOut(dayendDate, items.LineNo, items.Color, items.Size, items.StyleNo) + " In - " + items.Count + " Out -" + GetOutPut(dayendDate, items.LineNo, items.Color, items.Size, items.StyleNo));
                   GenaricRepository<Dayend> _DayendRepository = new GenaricRepository<Dayend>(new ItrackContext());
                   Dayend _dayend = new Dayend();
                   _dayend.DayendHeaderID = Convert.ToString(dayendDate.Year + dayendDate.Month + dayendDate.Day);
                   _dayend.DayendID = Convert.ToString(dayendDate.Year + dayendDate.Month + dayendDate.Day);
                   _dayend.Date = items.Date;
                   _dayend.LineNo = items.LineNo;
                   _dayend.StyleNo = items.StyleNo;
                   _dayend.Color = items.Color;
                   _dayend.Length = "None";
                   _dayend.Size = items.Size;
                   _dayend.LineIn = Convert.ToInt16(items.Count);

               //    _dayend.LineOut = GetOutPut(dayendDate, items.LineNo, items.Color, items.Size, items.StyleNo);

                   var co = from c in itemListOut where c.Color == _dayend.Color && c.Size == _dayend.Size && c.LineNo == _dayend.LineNo select c;
                   double i = co.Last().Count;

                   _dayend.LineOut =Convert.ToInt16(i);
                   _dayend.CutQty = GetCutOut(dayendDate, items.LineNo, items.Color, items.Size, items.StyleNo);
                   _DayendRepository.Add(_dayend);
               }

               return true;
           }
           catch (Exception ex)
           {

               Debug.WriteLine(ex.Message);
               return false;

           }

       }





     

       public static int GetOutPut(DateTime _date,string LineName,string _colorCode,string _Size,string _styleNo)
       {
           try
           {

               GenaricRepository<OprationBarcodes> _BarcodeEditRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
               var itemList = from items in _BarcodeEditRepository.GetAll().ToList() where items.OprationRole == "Out" && items.BundleDetails.BundleHeader.CuttingItem.Color == _colorCode && items.BundleDetails.BundleHeader.CuttingItem.Size == _Size && items.BundleDetails.BundleHeader.CuttingItem.CuttingHeader.StyleID == _styleNo && items.isOparationComplete == true && _date.Day == items.OprationComplteAt.Day && _date.Month == items.OprationComplteAt.Month && _date.Year == items.OprationComplteAt.Year group items by items.OprationComplteAt.Date into ItemG select new { Date = ItemG.Key, OutPut = ItemG.Sum(c => c.BundleDetails.NoOfItem) };

               return Convert.ToInt16(itemList.Last().OutPut);
              
           }
           catch (Exception ex)
           {
               Debug.WriteLine(ex.Message);
               return 0;

           }

       }





       public static int GetCutOut(DateTime _date, string LineName, string _colorCode, string _Size, string _styleNo)
       {
           try
           {

               GenaricRepository<CuttingItem> _CuttingRepository = new GenaricRepository<CuttingItem>(new ItrackContext());
               var itemList = from items in _CuttingRepository.GetAll().ToList() where _date.Day == items.Date.Day && items.CuttingHeader.StyleID == _styleNo && items.Size == _Size && items.Color == _colorCode && _date.Month == items.Date.Month && _date.Year == items.Date.Year
                              
                              group items by items.Date into ItemG select new { Date = ItemG.Key, OutPut = ItemG.Sum(c => c.NoOfItem) };

               return Convert.ToInt16(itemList.Last().OutPut);

           }
           catch (Exception ex)
           {
               Debug.WriteLine(ex.Message);
               return 0;

           }

       }



       public static async Task<bool> DoDayend(  Label lbl,DevExpress.XtraWaitForm.ProgressPanel pnl,DateTime _now) {
           try {

               lbl.Text = "Calculating Production Figures..";
               pnl.Show();
               await Task.Run(() =>
               {
                 //
                 //  GetProductionDaySummary(DateTime.Now);
                   

                   AddIndividualProductionSummary(_now);
                //   AddCuttingSummary(DateTime.Now);
               });

               lbl.Text = "Sucecessfuly Completed !";
               pnl.Hide();
               return true;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return false;
           }
       }


#region Individual Production Summary

       public static async Task<bool> AddIndividualProductionSummary(DateTime dayendDate)
       {
           try {

               GenaricRepository<OprationBarcodes> _OperationBarcode = new GenaricRepository<OprationBarcodes>(new ItrackContext());
               GenaricRepository<IndividualProductionSummery> _IndivialProudctionRepo = new GenaricRepository<IndividualProductionSummery>(new ItrackContext());
              
               IndividualProductionSummery _individualProductionSummary = new IndividualProductionSummery();

               var itemList = from items in _OperationBarcode.GetAll().ToList()

                              where  items.isOparationComplete == true && items.OprationComplteAt.Day == dayendDate.Day && items.OprationComplteAt.Month == dayendDate.Month && items.OprationComplteAt.Year == dayendDate.Year

                              group items by new { items.OprationComplteAt.Date, items.LineNo, items.EmployeeID,items.OprationNO, items.OparationName } into ItemG

                              select new { ItemG.Key.Date, ItemG.Key.LineNo, ItemG.Key.EmployeeID,ItemG.Key.OprationNO,  ItemG.Key.OparationName,TotalItem = ItemG.Sum(c => c.BundleDetails.NoOfItem), SMV = ItemG.Sum(c => c.OperationPool.SMV*c.BundleDetails.NoOfItem) };



               foreach (var summary in itemList)
               {

                   Debug.WriteLine("Employee Name -"  +summary.EmployeeID +" opration Name"+ summary.OparationName +" No Of Item - " + summary.TotalItem + " Total SAH - " + summary.SMV/60);
                   GenaricRepository<IndividualProductionSummery> _IndivialRepo = new GenaricRepository<IndividualProductionSummery>(new ItrackContext());
              
                   _individualProductionSummary.EmployeeID = summary.EmployeeID;
                   
                   _individualProductionSummary.OprationNo = summary.OprationNO;
                   _individualProductionSummary.Pcs =Convert.ToInt16( summary.TotalItem);
                   _individualProductionSummary.EarnSAH =Convert.ToDouble( (summary.SMV / 60).ToString("G7", CultureInfo.InvariantCulture));
                   _individualProductionSummary.Effiency = summary.SMV;
                   _individualProductionSummary.DayendHeaderID =  Convert.ToString(dayendDate.Year + dayendDate.Month + dayendDate.Day);
                   _individualProductionSummary.IndividualProductionSummeryID = _individualProductionSummary.DayendHeaderID + summary.EmployeeID;
                 _IndivialRepo.Insert(_individualProductionSummary);
 


               }

               return true;
           
           }
           catch(Exception ex){

               Debug.WriteLine(ex.Message);
               return false;
           }
       
       }



       public static void AddCuttingSummary(DateTime dayendDate) 
       {
           try {
                
                GenaricRepository<CuttingItem> _CUttingItemRepo = new GenaricRepository<CuttingItem>(new ItrackContext());
                GenaricRepository<CuttingSummary> _CUttingSummaryRepo = new GenaricRepository<CuttingSummary>(new ItrackContext());
                CuttingSummary _cSummary = new CuttingSummary();


                var CuttingItemList = from items in _CUttingItemRepo.GetAll().ToList()
                                      where items.Date.Day == dayendDate.Day && items.Date.Month == dayendDate.Month && items.Date.Year == dayendDate.Year
                                      select items;
                foreach( var item in CuttingItemList){

                    _cSummary.MarkerNo = item.MarkerNo;
                    _cSummary.CuttingIdDetails = item.CuttingItemID;
                    _cSummary.FabricType = item.FabricType;
                    _cSummary.Color = item.Color;
                    _cSummary.Size = item.Size;
                    _cSummary.NoPcs = item.NoOfItem;
                    _cSummary.DayendHeaderID = Convert.ToString(dayendDate.Year + dayendDate.Month + dayendDate.Day);
                    _CUttingSummaryRepo.Add(_cSummary);
                     Debug.WriteLine("Date :" + item.Date + " Cut No :" + item.CuttingItemID + " Fabric Type :"+ item.FabricType + " Color :" + item.Color + "  Size :" + item.Size + "PCS :" + item.NoOfItem);
                
                }


           }
           catch(Exception ex)
           {
               Debug.WriteLine(ex.Message);
           }
       
       }


 #endregion 

        #region Day end Report 

     

       public IEnumerable<DayendHeader> GetDayendHeader(DateTime _date) {
           try {
               GenaricRepository<DayendHeader> _DayendHeaderRepository = new GenaricRepository<DayendHeader>(new ItrackContext());
               var data = from items in _DayendHeaderRepository.GetAll().ToList()
                         // where _date.Day == items.Date.Day && _date.Month == items.Date.Month && _date.Year == items.Date.Year
                          select items;
               return data;

           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return null;
           }
       }




        #endregion

    }
}
