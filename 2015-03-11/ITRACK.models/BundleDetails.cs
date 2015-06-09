using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class BundleDetails
    {
        public int BundleDetailsID { get; set; }

        public string SerailNo { get; set; }
       
        public int NoOfItem { get; set; }

        public int CutNo { get; set; }

        public bool IsPrintBundleSticker { get; set; }

        public string BundleStickerPrintedBy { get; set; }


        public string BundleStickerPrintedTime { get; set; }


        public bool isBundleTagsPrinted { get; set; }

        public string BundleTagPrintedBy { get; set; }

        public string BundleTagPrintedTime { get; set; }

        public bool isSuspended { get; set; }

        public virtual BundleHeader BundleHeader { get; set; }


        public int BundleHeaderID  { get; set; }


    }
}
