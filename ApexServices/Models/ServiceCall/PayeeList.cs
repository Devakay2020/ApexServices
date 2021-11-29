using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class PayeeList : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var payeelListData = (Models.Data.PayeeListRequest)data;
            var requestData = new ApexServices.PayeeList.GetPayeeList();

            requestData.MessageID = payeelListData.EBSMessageID;
            requestData.MessageType = payeelListData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            requestData.WorkstationID = Settings.Workstation;

            requestData.CustomerNo = payeelListData.CustomerNo;

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + requestData.ToString());

            var client = new ApexServices.PayeeList.BB_Services_EngageServices_orcPayeeList_ReceivePayeeListRequestPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.PayeeList(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Models.Data.PayeeListRequest>(data);
        }
    }
}