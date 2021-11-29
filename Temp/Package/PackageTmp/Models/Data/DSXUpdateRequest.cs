using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class DSXUpdateRequest : EBSBaseRequest
    {
        public String DocumentUDI { get; set; }
        public String CustomerNo { get; set; }
        public String AccountNo { get; set; }
        public String BufferID { get; set; }
        public String Branch { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PostCode { get; set; }
        public String DocumentReference { get; set; }
        public String ActionStatus { get; set; }
        public String WorkLocation { get; set; }
        public String CaseReference { get; set; }
        public String ProcessStatus { get; set; }
        public String DocumentName { get; set; }
        public String CompletionDate { get; set; }
        public String DocumentDate { get; set; }
        public String DocumentTime { get; set; }
        //public String MessageType { get; set; }
        //public String MessageID { get; set; }
    }
}