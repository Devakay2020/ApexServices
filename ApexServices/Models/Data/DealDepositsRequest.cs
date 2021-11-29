/* ---------------------------------------------------------------------------------------------------------------- */
/* C0491    New DealDeposits Message                                                                                */
/* ---------------------------------------------------------------------------------------------------------------- */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class DealDepositsRequest : EBSBaseRequest
    {
        public String Customer { get; set; }
        public String AccountNumber { get; set; }
        public String DealReference { get; set; }
        
        
    }
}