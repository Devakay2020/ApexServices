using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using ApexServices.Models.Data;

namespace ApexServices.Models.ServiceCall
{
    public class IssueBankersDraft : IServiceCall
    {
        public JsonResponse Process(object data)
        {
            var withdrawData = (Models.Data.IssueBankersDraftRequest)data;
            var request = new ApexServices.IssueBankersDraft.BankersDraftIssuing();
            request.AcctNo = withdrawData.AccNo;
            request.ChequeSerialNo = withdrawData.ChequeSerialNo;
            request.EBSUserID = withdrawData.EBSUserId;
            request.MessageID = withdrawData.EBSMessageID;
            request.MessageType = withdrawData.EBSMessageType;
            request.PayeeName = withdrawData.PayeeName;
            request.SourceID = Settings.Source;
            request.TransactionAmount = withdrawData.TransactionAmount;
            request.TransactionCurrency = withdrawData.TransactionCurrency;
            request.TransactionNarrativeLine1 = withdrawData.TransactionNarrativeLine1;
            request.TransactionNarrativeLine2 = withdrawData.TransactionNarrativeLine2;
            request.TransactionNarrativeLine3 = withdrawData.TransactionNarrativeLine3;
            request.TransactionNarrativeLine4 = withdrawData.TransactionNarrativeLine4;
            request.ValueDate = withdrawData.ValueDate;
            request.WorkstationID = Settings.Workstation;


            var client =
                new ApexServices.IssueBankersDraft.
                    BB_Services_CashierServices_orcIssueBankersDraft_ReceiveIssueBankersDraftRequestPortSoapClient();
            var returnValue = client.IssueBankersDraft(request);
            return new JsonResponse() { Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Models.Data.IssueBankersDraftRequest>(data);
        }
    }
}