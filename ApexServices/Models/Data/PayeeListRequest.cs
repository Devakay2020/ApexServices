﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class PayeeListRequest : EBSBaseRequest
    {
        public String CustomerNo { get; set; }
    }
}