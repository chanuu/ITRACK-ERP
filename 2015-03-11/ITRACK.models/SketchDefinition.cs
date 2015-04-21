using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public class SketchDefinition
    {
        public Int32 SketchDefinitionID { get; set; }

        public string SketchName { get; set; }

        public string Remark { get; set; }

        
        public string StyleID { get; set; }

        public virtual Style Company { get; set; }

        public virtual ICollection<PartDefinition> PartDefinition { get; set; }
    }
}
