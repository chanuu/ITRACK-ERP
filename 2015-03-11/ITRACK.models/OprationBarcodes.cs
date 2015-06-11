using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public  class OprationBarcodes
    {
        public string OprationBarcodesID { get; set; }

        public string OprationNO { get; set; }

        public string  OparationName { get; set; }

        public string  OprationGrade { get; set; }

        public string  OprationRole  { get; set; }


        public string  PartName { get; set; }


        public bool isOparationComplete { get; set; }


        public DateTime OprationComplteAt { get; set; }


        public string  EmployeeID { get; set; }

        public virtual BundleDetails BundleDetails { get; set; }

        public int BundleDetailsID { get; set; }

       
      //  public string  ColorCode { get; set; }

      //  public string Size { get; set; }


   //     public string  Length { get; set; }





    }
}
