/* ---------------------------------------------------------------------------------------------------------------- */
/* C0???    New Open FIT Account Message                                                                            */
/* ---------------------------------------------------------------------------------------------------------------- */

using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class OFARequest : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var OFAData = (Data.OFARequest)data;
            var requestData = new ApexServices.OpenFITAccount.OpenFITAccount();

            requestData.MessageID = OFAData.EBSMessageID;
            requestData.MessageType = OFAData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            //requestData.WorkstationID = Settings.Workstation;

            requestData.Customer = OFAData.Customer;
            requestData.AccountType = OFAData.AccountType;
            requestData.OpportunityReference = OFAData.OpportunityReference;
            requestData.Spare1 = OFAData.Spare1;
            requestData.Spare2 = OFAData.Spare2;
            requestData.Spare3 = OFAData.Spare3;
            requestData.Spare4 = OFAData.Spare4;
            requestData.Spare5 = OFAData.Spare5;
            
            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + OFAData.ToString());

            var client = new ApexServices.OpenFITAccount.Bank_Biztalk_FundsInTransit_orcProcessOpenFITAccount_ReceiveOFAPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.OFA(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Data.OFARequest>(data);
        }
    }
}