/* ---------------------------------------------------------------------------------------------------------------- */
/* C0???    New Open FIT Account Message                                                                            */
/* ---------------------------------------------------------------------------------------------------------------- */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class OFARequest : EBSBaseRequest
    {
        public String Customer { get; set; }
        public String AccountType { get; set; }
        public String OpportunityReference { get; set; }
        public String Spare1 { get; set; }
        public String Spare2 { get; set; }
        public String Spare3 { get; set; }
        public String Spare4 { get; set; }
        public String Spare5 { get; set; }
    }
}