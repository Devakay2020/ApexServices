using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class EBSBaseRequest : BaseRequest
    {
        public String EBSMessageID { get; set; }
        public String EBSMessageType { get; set; }
        public String EBSUserId { get; set; }
        public String Source { get; set; }
        public String Workstation { get; set; }
    }
}