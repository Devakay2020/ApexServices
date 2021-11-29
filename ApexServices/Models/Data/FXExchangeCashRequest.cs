/* ---------------------------------------------------------------------------------------------------------------- */
/* C0491    New DealDeposits Message                                                                                */
/* ---------------------------------------------------------------------------------------------------------------- */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class FXExchangeCashRequest : EBSBaseRequest
    {
        public String BuyCurrency { get; set; }
        public String SellCurrency { get; set; }
        public String BuyAmount { get; set; }
        public String SellAmount { get; set; }
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
        public String RoundingBuyCurrency { get; set; }
        public String RoundingSellCurrency { get; set; }
        public String RoundingBuyAmount { get; set; }
        public String RoundingSellAmount { get; set; }
        public String Spare1 { get; set; }
        public String Spare2 { get; set; }
        public String Spare3 { get; set; }
        public String Spare4 { get; set; }
        public String Spare5 { get; set; }
        
       
        
        
    }
}