using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class BundleHeader
    {
        public int BundleHeaderID { get; set; }

        public bool isBundleTagsGerated { get; set; }

        public string BundleTagGenaratedBy { get; set; }

        public string BundleTagGenaratedTime { get; set; }

        public bool isOprationTagGenated { get; set; }

        public string OprationTagGeratedBy { get; set; }

        public string OprationTagGenaratedTime { get; set; }

        public virtual CuttingItem CuttingItem { get; set; }

        public int  CuttingItemID { get; set; }


        public virtual ICollection<BundleDetails> BundleDetails { get; set; }
        




    }
}
