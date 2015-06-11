using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.ViewModel
{
   public class GenarateTags
    {

       private int LastBundleNo=0;
       private int LastTagNo;
       private int LastCutNo;
       private int NoOfBundle;
       private int Remain;
       private bool isSmallBundleExist = false;
       BundleDetails _bandleDetails = new BundleDetails();
       OprationBarcodes _barcode = new OprationBarcodes();

       public bool genarateBundle(int _noOfLayer,int _noOfItem,int _bundleSize) {
           try {

               LastBundleNo = GetLastBundleNo();
               NoOfBundle = _noOfLayer / _bundleSize;

               Remain = _noOfLayer -  NoOfBundle * _bundleSize;

               if (Remain > 0)
               {
                   NoOfBundle = NoOfBundle + 1;
                   Debug.WriteLine("No of Bundle :" + NoOfBundle);
                   NoOfBundle = NoOfBundle - 1;
                   isSmallBundleExist = true;
               }
               else {
                   Debug.WriteLine("No of Bundle :" + NoOfBundle);
              
               
               }

               Debug.WriteLine(_bundleSize + "*" + NoOfBundle);
               Debug.WriteLine(Remain + "*" + 1);


               for (int y = 1; y <= _noOfItem; y++) 
               {
              
                  LastBundleNo = 0;
                
                   for (int i = 0; i < NoOfBundle; i++)
                       {

                           Debug.WriteLine("Bundle ID : + " + ((y - 1) * NoOfBundle + i+1).ToString().PadLeft(10, '0') + " |    No of Item" + _bundleSize + " |  Cut No" + y);
                           LastBundleNo = i + 1;
                       }


                       if (isSmallBundleExist == true)
                       {
                           Debug.WriteLine("Bundle ID : + " + ((y-1) *NoOfBundle+ LastBundleNo).ToString().PadLeft(10, '0') + " |    No of Item" + Remain + " |  Cut No" + y);
                       }

              
                   Debug.WriteLine("Cut No -"+y);
               
               }

                   



                   return true;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return false;
           }
       }


       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public bool addBundleDetails(BundleDetails _bandle,int _bundleHeaderID) {
           try {

               GenaricRepository<BundleDetails> _BundleDetails = new GenaricRepository<BundleDetails>(new ItrackContext());
               _bandle.BundleHeaderID = _bundleHeaderID;

               _bandle.BundleTagPrintedBy = "None";
               _bandle.BundleTagPrintedTime = "None";
               _bandle.isBundleTagsPrinted = false;
               _bandle.BundleStickerPrintedBy = "None";
               _bandle.BundleStickerPrintedTime = "None";
               _bandle.BundleTagPrintedBy = "None";


               _BundleDetails.Insert(_bandle);
               
               return true;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return false;
           }
       }

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>

       private int GetLastCutNo() {
           try {

               GenaricRepository<BundleDetails> _BundleDetails = new GenaricRepository<BundleDetails>(new ItrackContext());
               return  _BundleDetails.GetAll().ToList().Last().CutNo;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return 0;
           }
       }


       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       private int GetLastBundleNo() {
           try {

               GenaricRepository<BundleDetails> _BundleDetails = new GenaricRepository<BundleDetails>(new ItrackContext());
               return Convert.ToInt16(_BundleDetails.GetAll().ToList().Last().SerailNo);
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return 0;
           }
       }

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       private int GetLastTagNo()
       {
           try
           {

               GenaricRepository<OprationBarcodes> _barcoderepo = new GenaricRepository<OprationBarcodes>(new ItrackContext());
               return Convert.ToInt16(_barcoderepo.GetAll().ToList().Last().OprationBarcodesID);
           }
           catch (Exception ex)
           {
               Debug.WriteLine(ex.Message);
               return 0;
           }
       }

       /// <summary>
       /// 
       /// </summary>
       /// <param name="_bundleDetails"></param>
       /// <param name="_ditem"></param>
       /// <returns></returns>
       public bool OprationTags(BundleDetails _bundleDetails,string _style,string _LineNo ) {
           try {

               LastTagNo = GetLastTagNo() +1;
            



                   GenaricRepository<DividingPlanHeader> _DividingPlanHeader = new GenaricRepository<DividingPlanHeader>(new ItrackContext());
                   GenaricRepository<DividingPlanItem> _DividingPlanItemRepo = new GenaricRepository<DividingPlanItem>(new ItrackContext());

                   var dividingHeader = from item in _DividingPlanHeader.GetAll().ToList() where item.StyleID == _style && item.LineNo == _LineNo  select item;

                   if (dividingHeader.Count() > 0) 
                   {

                       int dividingheaderID = dividingHeader.Last().DividingPlanheaderID;


                       foreach (var item in _DividingPlanItemRepo.GetAll().ToList())
                       {

                           GenaricRepository<OprationBarcodes> _OprationTagsRepo = new GenaricRepository<OprationBarcodes>(new ItrackContext());

                           _barcode.OprationBarcodesID = LastTagNo.ToString().PadLeft(14, '0');
                           _barcode.OprationNO = item.OprationNo;
                           _barcode.OprationRole = "";
                           _barcode.OprationGrade = "A";
                           _barcode.PartName = item.PartName;
                           _barcode.OparationName = item.OprationName;
                           _barcode.EmployeeID = "None";
                           _barcode.isOparationComplete = false;
                           _barcode.OprationComplteAt = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                           _barcode.BundleDetailsID = _bundleDetails.BundleDetailsID;
                           _OprationTagsRepo.Insert(_barcode);

                           LastTagNo = LastTagNo + 1;



                       }

                  
                   
                   
                 


                   
                   
               }

               return true;
           }
           catch(Exception ex){
               return false;
           }
       }



       public void genarateTestData() {
           try {
           

               for(int i = 0 ; i <6000000; i++){
                
                   
                           GenaricRepository<OprationBarcodes> _OprationTagsRepo = new GenaricRepository<OprationBarcodes>(new ItrackContext());

                           _barcode.OprationBarcodesID = i.ToString().PadLeft(14, '0');
                           _barcode.OprationNO = "A";
                           _barcode.OprationRole = "";
                           _barcode.OprationGrade = "A";
                           _barcode.PartName = "";
                           _barcode.OparationName = "A"+i;
                           _barcode.EmployeeID = "None";
                           _barcode.isOparationComplete = false;
                           _barcode.OprationComplteAt = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                           _barcode.BundleDetailsID = 449;
                           _OprationTagsRepo.Insert(_barcode);
               
               }
           
           }
           catch(Exception ex){
           
           
           
           }
       
       }












       /// <summary>
       /// 
       /// </summary>
       /// <param name="_noOfLayer"></param>
       /// <param name="_noOfItem"></param>
       /// <param name="_bundleSize"></param>
       /// <param name="_bandleHeader"></param>
       /// <returns></returns>
       public bool GenrateBundleTags(int _noOfLayer, int _noOfItem, int _bundleSize,int _bandleHeader,string _styneNo,string _lineNo)
       {
           try {

               LastBundleNo = GetLastBundleNo();
               LastCutNo = GetLastCutNo();
               NoOfBundle = _noOfLayer / _bundleSize;

               Remain = _noOfLayer - NoOfBundle * _bundleSize;

               if (Remain > 0)
               {
                   NoOfBundle = NoOfBundle + 1;
                   Debug.WriteLine("No of Bundle :" + NoOfBundle);
                   NoOfBundle = NoOfBundle - 1;
                   isSmallBundleExist = true;
               }
               else
               {
                   Debug.WriteLine("No of Bundle :" + NoOfBundle);


               }


               for (int i = 0; i < _noOfItem; i++)
               {



                   Debug.WriteLine("Cut No :" + i);
                   LastCutNo = LastCutNo + 1;
                   for (int j = 0; j < NoOfBundle; j++)
                   {

                       
                       LastBundleNo = LastBundleNo + 1;

                      // Debug.WriteLine("Bundle No :" + LastBundleNo.ToString().PadLeft(10, '0') + "    No Of Item :" + _bundleSize + "  Cut No :" + i);
                       _bandleDetails.CutNo = LastCutNo;
                       _bandleDetails.SerailNo = LastBundleNo.ToString().PadLeft(10, '0');
                       _bandleDetails.NoOfItem = _bundleSize;

                       addBundleDetails(_bandleDetails, _bandleHeader);
                       
                       OprationTags(_bandleDetails,_styneNo,_lineNo);



                   }

                   if (isSmallBundleExist == true) {
                       LastBundleNo = LastBundleNo + 1;

                    //   Debug.WriteLine("Bundle No :" + LastBundleNo.ToString().PadLeft(10, '0') + "    No Of Item :" + Remain + "  Cut No :" + i);
                       _bandleDetails.CutNo = LastCutNo;
                       _bandleDetails.SerailNo = LastBundleNo.ToString().PadLeft(10, '0');
                       _bandleDetails.NoOfItem = Remain;
                       addBundleDetails(_bandleDetails, _bandleHeader);
                      // OprationTags(_bandleDetails, _styneNo, _lineNo);
                   
                   }




               }


                   return true;
           }
           catch(Exception ex){
               Debug.WriteLine(ex.Message);
               return false;
           }
       
       }
    }
}
