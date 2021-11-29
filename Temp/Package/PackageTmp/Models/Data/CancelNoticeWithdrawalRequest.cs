using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class CancelNoticeWithdrawalRequest : EBSBaseRequest
    {
        public String AccountNo { get; set; }
        public String NoticeReference { get; set; }
    }
}