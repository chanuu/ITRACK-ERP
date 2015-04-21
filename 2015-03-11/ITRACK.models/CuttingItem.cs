using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class CuttingItem
    {
        public int CuttingItemID { get; set; }

        public string MarkerNo { get; set; }

        public string Color{ get; set; }

        public string Size { get; set; }
                
        public string Length { get; set; }

        public int NoOfItem { get; set; }

        public int NoOfLayer  { get; set; }


        public int NoOfPlysPlaned { get; set; }

        public int NoOfPlysLayed { get; set; }

        public virtual CuttingHeader CuttingHeader { get; set; }

        public string CuttingHeaderID { get; set; }




    }
}
