/* ---------------------------------------------------------------------------------------------------------------- */
/* C0491    New Deal Finance Message                                                                                */
/* ---------------------------------------------------------------------------------------------------------------- */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class DealFinanceRequest : EBSBaseRequest
    {
        
        public String AccountNumber { get; set; }
        public String NumberOfPaymentsToRetrieve { get; set; }
        
        
    }
}