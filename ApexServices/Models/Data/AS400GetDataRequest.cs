using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class AS400GetDataRequest : EBSBaseRequest
    {
        public List<String> Templates { get; set; }
    }
}