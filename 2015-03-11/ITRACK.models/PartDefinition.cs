using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class PartDefinition
    {
         [Key]
        public string PartDefinitionID { get; set; }

         public string PartName { get; set; }

         public string Remark { get; set; }



    }
}
