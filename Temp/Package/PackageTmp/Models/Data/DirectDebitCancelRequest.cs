using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class DirectDebitCancelRequest : EBSBaseRequest
    {
        public String AccountId { get; set; }
        public String DDRef { get; set; }
    }
}