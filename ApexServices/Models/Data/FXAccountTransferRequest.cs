/* ---------------------------------------------------------------------------------------------------------------- */
/* C0???    New FX Message                                                                                */
/* ---------------------------------------------------------------------------------------------------------------- */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class FXAccountTransferRequest : EBSBaseRequest
    {
        public String DebitCurrency { get; set; }
        public String CreditCurrency { get; set; }
        public String DebitAmount { get; set; }
        public String CreditAmount { get; set; }
        public String ExchangeRate { get; set; }
        public String ValueDate { get; set; }
        public String TransactionReference { get; set; }
        public String TransactionNarrativeLine1 { get; set; }
        public String TransactionNarrativeLine2 { get; set; }
        public String TransactionNarrativeLine3 { get; set; }
        public String TransactionNarrativeLine4 { get; set; }
        public String DebitSystemParameter { get; set; }
        public String CreditSystemParameter { get; set; }
        public String OverrideUser { get; set; }
        public String DebitAccountNumber { get; set; }
        public String CreditAccountNumber { get; set; }
        public String Spare1 { get; set; }
        public String Spare2 { get; set; }
        public String Spare3 { get; set; }
        public String Spare4 { get; set; }
        public String Spare5 { get; set; }
        
       
        
        
    }
}