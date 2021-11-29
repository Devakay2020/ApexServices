using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class BaseRequestGET
    {
        // C0225 public String RequestId { get; set; }
        public String ServiceName { get; set; }
        public String Token { get; set; }
        public String Source { get; set; }
        public String User { get; set; }

        /* C0225 */
        public String MessageId { get; set; }
        public Boolean Authenticated { get; set; }

        /* C0CPDR */
        public String EBSUserId { get; set; }
        public String EBSMessageType { get; set; }
        public String EBSMessageId { get; set; }
        public String CustomerId { get;  set; }

    }
}