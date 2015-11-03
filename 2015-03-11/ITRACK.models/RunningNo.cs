using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class RunningNo
    {
        public string RunningNoID { get; set; }

        public string Code { get; set; }

        public Int32 Starting { get; set; }

        public Int32 Length { get; set; }

        public string Prefix { get; set; }

        public string Venue { get; set; }

        public virtual Company Company { get; set; }

        public Int32 CompanyID { get; set; }




        
    }
   
}
