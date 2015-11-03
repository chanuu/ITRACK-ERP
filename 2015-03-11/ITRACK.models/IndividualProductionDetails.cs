using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class IndividualProductionDetails
    {

       public string IndividualProductionDetailsID { get; set; }
       public string StyleNo { get; set; }

        public DateTime Date { get; set; }

        public int HourNo { get; set; }

        public int WorkstationNo { get; set; }

        public string OperationNo { get; set; }


        public string OperationName { get; set; }


        public int Pcs { get; set; }

        public double SMV { get; set; }


        public double SAH { get; set; }

        public double Efficiency { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }
    }
}
