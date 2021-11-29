using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class NoticeWithdrawalList : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var noticeWithdrawalListData = (Models.Data.NoticeWithdrawalListRequest)data;
            var requestData = new ApexServices.GetNoticeWithdrawalList.GetNoticeWithdrawals();

            requestData.MessageID = noticeWithdrawalListData.EBSMessageID;
            requestData.MessageType = noticeWithdrawalListData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            requestData.WorkstationID = Settings.Workstation;

            requestData.AccountNumber = noticeWithdrawalListData.AccountNo;

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + requestData.ToString());

            var client = new ApexServices.GetNoticeWithdrawalList.BB_Services_EngageServices_orcGetNoticeWithdrawalList_ReceiveGetNoticeWithdrawalsPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.NoticeWithdrawalList(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Models.Data.NoticeWithdrawalListRequest>(data);
        }
    }
}