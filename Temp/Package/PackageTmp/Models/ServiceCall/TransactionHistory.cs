using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class TransactionHistory : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
           // var requestData = (TransactionHistoryRequest) data;
            //var deposit = (Models.Data.ChequeDepositRequest)data;
            //var request = new ApexServices.ChequeDeposit.ChequeDeposit();
            //var requestData = new ApexServices.AccountSummary.AccountSummaryAccountSummaryRequest();

            var request = (TransactionHistoryRequest) data;



            var requestData = new ApexServices.TransactionHistory.TransactionHistoryEngageTransactionHistoryEngage();

            requestData.MessageID = request.MessageId;
            //requestData.EBSMessageID = requestData.EBSMessageID;
            
            requestData.MessageType = "TransactionHistoryEngage";
            //requestData.TransactionHistoryEngage..EBSUserId = request.EBSUserId;
            requestData.SourceID = Settings.Source;
            //requestData.Workstation = Settings.Workstation;   
            
            requestData.AccountNumber = request.AccountNo;
            requestData.FromDate = request.FromDate;
            requestData.NoOfTransactions = request.NoOfTransactions;
            requestData.SessionID = request.SessionID;
            requestData.Spare1 = request.Spare1;
            requestData.Spare2 = request.Spare2;
            requestData.Spare3 = request.Spare3;
            requestData.Spare4 = request.Spare4;
            requestData.Spare5 = request.Spare5;
            requestData.ToDate = request.ToDate;
            requestData.TranPeriod = request.TranPeriod;

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + requestData.ToString());

            var client = new ApexServices.TransactionHistory.BB_Services_EngageServices_orcTransactionHistoryEngage_ReceiveTransactionHistoryEngagePortSoapClient();

            var stop = new Stopwatch();
            stop.Start();
            
            //var returnValue = client.TransactionHistoryEngage(request);
            var returnValue  = client.TransactionHistoryEngage(requestData);
            //var returnValue = client.TransactionHistoryEngage(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<TransactionHistoryRequest>(data);
        }
    }
}