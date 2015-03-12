using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class User
    {
        [Key] 
        public string UserID { get; set; }

        public string FirstName  { get; set; }

        public string  LastName { get; set; }

        public string  EmailAddress { get; set; }

        public string TeleNo { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }



    }
}
