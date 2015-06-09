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

       private int LastBundleNo=160;
       private int LastTagNo;
       private int LastCutNo;
       private int NoOfBundle;
       private int Remain;
       private bool isSmallBundleExist = false;

       public bool genarateBundle(int _noOfLayer,int _noOfItem,int _bundleSize) {
           try {


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



       public bool GenrateBundleTags(int _noOfLayer, int _noOfItem, int _bundleSize)
       {
           try {
              
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

                   for (int j = 0; j < NoOfBundle; j++)
                   {

                       
                       LastBundleNo = LastBundleNo + 1;

                       Debug.WriteLine("Bundle No :" + LastBundleNo.ToString().PadLeft(10, '0') + "    No Of Item :" + _bundleSize + "  Cut No :" + i);
                   }

                   if (isSmallBundleExist == true) {
                       LastBundleNo = LastBundleNo + 1;

                       Debug.WriteLine("Bundle No :" + LastBundleNo.ToString().PadLeft(10, '0') + "    No Of Item :" + Remain + "  Cut No :" + i);
                   
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
