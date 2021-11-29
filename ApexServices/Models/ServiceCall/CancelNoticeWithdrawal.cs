using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class CancelNoticeWithdrawal : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var cancelTransactionData = (CancelNoticeWithdrawalRequest)data;
            var requestData = new ApexServices.CancelNoticeWithdrawal.CancelNoticeWithdrawal();

            requestData.MessageID = cancelTransactionData.EBSMessageID;
            requestData.MessageType = cancelTransactionData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            requestData.WorkstationID = Settings.Workstation;

            requestData.AccountNumber = cancelTransactionData.AccountNo;
            requestData.NoticeReference = cancelTransactionData.NoticeReference;

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + cancelTransactionData.ToString());

            var client = new ApexServices.CancelNoticeWithdrawal.BB_Services_EngageServices_orcCancelNoticeWithdrawal_ReceiveCancelNoticeWithdrawalPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.CancelNoticeWithdrawal(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<CancelNoticeWithdrawalRequest>(data);
        }
    }
}