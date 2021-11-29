/* ---------------------------------------------------------------------------------------------------------------- */
/* C0???   New DealDeposits Message                                                                                */
/* ---------------------------------------------------------------------------------------------------------------- */

using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class FTVRequest : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var FTVData = (Data.FTVRequest)data;
            var requestData = new ApexServices.FTVInformation.FTVRequest();

            requestData.MessageID = FTVData.EBSMessageID;
            requestData.MessageType = FTVData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            //requestData.WorkstationID = Settings.Workstation;

            requestData.AccountNumber = FTVData.AccountNumber;
            
            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + FTVData.ToString());

            var client = new ApexServices.FTVInformation.Bank_Biztalk_FTVInformation_orcProcessFTV_ReceiveFTVPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.FTV(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Data.FTVRequest>(data);
        }
    }
}