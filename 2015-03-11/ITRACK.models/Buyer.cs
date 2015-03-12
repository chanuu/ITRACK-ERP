﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
 public   class Buyer
    {
        public Int32 BuyerID { get; set; }

        public string BuyerName { get; set; }

        public string  BuyerShippingAddress { get; set; }

        public string  BuyerTeleNo { get; set; }

        public string  FaxNo { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }


    }
}