/* ---------------------------------------------------------------------------------------------------------------- */
/* C0491    New DealFinance Message                                                                                */
/* ---------------------------------------------------------------------------------------------------------------- */

using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class DealFinance : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var dealFinanceData = (Data.DealFinanceRequest)data;
            var requestData = new ApexServices.DealFinance.FinanceRequestDealFinance();

            requestData.MessageID = dealFinanceData.EBSMessageID;
            requestData.MessageType = dealFinanceData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            //requestData.WorkstationID = Settings.Workstation;

            requestData.AccountNumber = dealFinanceData.AccountNumber;
            requestData.NumberOfPaymentsToRetrieve = dealFinanceData.NumberOfPaymentsToRetrieve;

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + dealFinanceData.ToString());

            var client = new ApexServices.DealFinance.Bank_Biztalk_DealsInformation_orcProcessFinanceInformation_ReceiveFinanceRequestPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.FinanceRequest(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<DealFinanceRequest>(data);
        }
    }
}