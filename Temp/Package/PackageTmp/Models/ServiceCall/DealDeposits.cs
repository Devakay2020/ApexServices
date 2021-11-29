/* ---------------------------------------------------------------------------------------------------------------- */
/* C0491    New DealDeposits Message                                                                                */
/* ---------------------------------------------------------------------------------------------------------------- */

using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class DealDeposits : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var dealDepositsData = (Data.DealDepositsRequest)data;
            var requestData = new ApexServices.DealDeposits.DepositInformationDealDeposits();

            requestData.MessageID = dealDepositsData.EBSMessageID;
            requestData.MessageType = dealDepositsData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            //requestData.WorkstationID = Settings.Workstation;

            requestData.AccountNumber = dealDepositsData.AccountNumber;
            requestData.Customer = dealDepositsData.Customer;
            requestData.DealReference = dealDepositsData.DealReference;

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + dealDepositsData.ToString());

            var client = new ApexServices.DealDeposits.Bank_Biztalk_DealsInformation_orcProcessDepositInformation_ReceiveDepositPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.DepositInformation(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<DealDepositsRequest>(data);
        }
    }
}