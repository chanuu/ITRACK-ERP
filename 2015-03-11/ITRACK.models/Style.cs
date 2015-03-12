using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class Style
    {

        [Key] 
        public string StyleID { get; set; }

        public string Article { get; set; }

        public int Season { get; set; }

        public string GarmantType { get; set; }


        public string Status { get; set; }


        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<SketchDefinition> SketchDefinition { get; set; }
    }
}
