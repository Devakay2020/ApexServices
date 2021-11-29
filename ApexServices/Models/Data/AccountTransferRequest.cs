using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class AccountTransferRequest : EBSBaseRequest
    {
        public String BeneficiaryName { get; set; }
        public String BeneficiaryReference { get; set; }
        public String ChargeAmount { get; set; }
        public String ChargeCode { get; set; }
        public String CreditAccountNo { get; set; }
        public String CreditSystemParameter { get; set; }
        public String DebitAccountNo { get; set; }
        public String DebitSystemParameter { get; set; }
        public String ExchangeRate { get; set; }
        public String NarrativeLine1 { get; set; }
        public String NarrativeLine2 { get; set; }
        public String NarrativeLine3 { get; set; }
        public String NarrativeLine4 { get; set; }
        public String OverrideUser { get; set; }
        public String Spare1 { get; set; }
        public String Spare2 { get; set; }
        public String Spare3 { get; set; }
        public String Spare4 { get; set; }
        public String Spare5 { get; set; }
        public String TransactionAmount { get; set; }
        public String TransactionCurrency { get; set; }
        public String TransferDueDate { get; set; }
        public String TransferFromAccountNo { get; set; }
        public String TransactionReference { get; set; }
        public String TransferToAccountNo { get; set; }
        public String TransferToSortcode { get; set; }
        public String TransferType { get; set; }

        /* CPDR ??? */
        public String NoticeWithdrawalType { get; set; }
        public String NoticeGivenDate { get; set; }
        public String NoticeMaturityDate { get; set; }
        public String CloseNoticeAccount { get; set; }
    }
}