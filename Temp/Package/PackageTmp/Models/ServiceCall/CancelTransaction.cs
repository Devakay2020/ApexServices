using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class CancelTransaction : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var cancelTransactionData = (CancelTransactionRequest)data;
            var requestData = new ApexServices.CancelTransaction.CancelTransactionEngage();

            requestData.MessageID = cancelTransactionData.EBSMessageID;
            requestData.MessageType = cancelTransactionData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            //requestData.WorkstationID = Settings.Workstation;

            /* CPDR01 */
            requestData.EBSUserID = cancelTransactionData.EBSUserId;

             /* CPDR01 */
            requestData.OriginalMessageID = cancelTransactionData.OriginalMessageId;
            requestData.Spare1 = cancelTransactionData.Spare1;
            requestData.Spare2 = cancelTransactionData.Spare2;
            requestData.Spare3 = cancelTransactionData.Spare3;
            requestData.Spare4 = cancelTransactionData.Spare4;
            requestData.Spare5 = cancelTransactionData.Spare5;

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + cancelTransactionData.ToString());

            var client = new ApexServices.CancelTransaction.BB_Services_EngageServices_orcCancelTransactionEngage_ReceiveCancelTransactionRequestPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.CancelTransaction(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<CancelTransactionRequest>(data);
        }
    }
}