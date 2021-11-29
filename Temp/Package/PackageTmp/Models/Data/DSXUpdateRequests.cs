using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class DSXUpdateRequests : EBSBaseRequest
    {
        public List<DSXUpdateRequest> DSXUpdRequests { get; set; }
    }
}