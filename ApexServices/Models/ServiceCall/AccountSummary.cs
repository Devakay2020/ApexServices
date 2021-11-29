using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class AccountSummary : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var summaryData = (AccountSummaryRequest) data;
            var requestData = new ApexServices.AccountSummary.AccountSummaryAccountSummaryRequest();

            requestData.MessageID = summaryData.EBSMessageID;
            requestData.MessageType = summaryData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            requestData.WorkstationID = Settings.Workstation;

            requestData.CustomerNo = summaryData.CustomerId;

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + requestData.ToString());

            var client = new ApexServices.AccountSummary.BB_Services_EngageServices_orcAccountSummary_ReceiveAccountSummaryPortSoapClient();
            
            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.AccountSummary(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue.AccountSummary };

/*
            var acc = new AccountSummaryAccountSummaryRequest { CustomerNo = summaryData.CustomerId, SourceID = Settings.Source, WorkstationID = Settings.Workstation, MessageType = "AccountSummaryEngage", MessageID = summaryData.EBSMessageID };



            var service = new BB_Services_CashierServices_orcAccountSummary_ReceiveAccountSummaryPortSoapClient();
            var stop = new Stopwatch();
            stop.Start();

            LogHelper.Info(Log, "Request Data : " + new JavaScriptSerializer().Serialize(summaryData));

            var returndata = service.AccountSummary(acc);
            stop.Stop();

            return new JsonResponse(){ CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returndata.AccountSummary};
 */
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<AccountSummaryRequest>(data);
        }
    }
}