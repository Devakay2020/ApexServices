﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class AccountSummaryRequest : EBSBaseRequest
    {
        public String CustomerId { get; set; }
    }
}