/* -------------------------------------------------------------------------------------------------------------------- */
/* C0284	Cheque Deposit requires new mapping																			*/
/* -------------------------------------------------------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class ChequeDepositRequest : EBSBaseRequest
    {
        public String CreditAccountNo { get; set; }
        public String DebitAccountNo { get; set; }
        public String ChargeAmount { get; set; }
        public String ChargeCode { get; set; }
        public String TransactionAmount { get; set; }
        public String TransactionCurrency { get; set; }
        public String ChequeSerialNo { get; set; }
        public String ChequeType { get; set; }

        /* C0284 */
        public String DepositReference { get; set; }
        public String TransactionNarrativeLine1 { get; set; }
        public String TransactionNarrativeLine2 { get; set; }
        public String TransactionNarrativeLine3 { get; set; }
        public String TransactionNarrativeLine4 { get; set; }
        /* C0284 */


        public String CreditSystemParameter { get; set; }
        public String DebitSystemParameter { get; set; }
        public String TransactionReference { get; set; }
        public String IssuingBank { get; set; }
        public String OverrideUser { get; set; }
        public String NoOfCheques { get; set; }
        public String Spare1 { get; set; }
        public String Spare2 { get; set; }
        public String Spare3 { get; set; }
        public String Spare4 { get; set; }
        public String Spare5 { get; set; }
        public String ValueDate { get; set; }
    }
}