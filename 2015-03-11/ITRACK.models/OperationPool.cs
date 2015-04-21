using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class OperationPool
    {
        public string OperationPoolID { get; set; }

        public string OpationName { get; set; }

        public double SMV { get; set; }

        public string SMVType { get; set; }

        public string Remark { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<StyleOperation> StyleOperation { get; set; }
    }
}
