using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class TransactionHistoryRequest : EBSBaseRequest
    {
        public String AccountNo { get; set; }
        public String FromDate { get; set; }
        public String NoOfTransactions { get; set; }
        public String SessionID { get; set; }
        public String Spare1 { get; set; }
        public String Spare2 { get; set; }
        public String Spare3 { get; set; }
        public String Spare4 { get; set; }
        public String Spare5 { get; set; }
        public String ToDate { get; set; }
        public String TranPeriod { get; set; }
    }
}