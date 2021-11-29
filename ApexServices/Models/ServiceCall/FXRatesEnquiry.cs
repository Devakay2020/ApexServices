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
    public class FXRatesEnquiry : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var FXData = (Data.FXRatesEnquiryRequest)data;
            var requestData = new ApexServices.FXRates.FXRatesFXRatesEnquiry();

            requestData.MessageID = FXData.EBSMessageID;
            requestData.MessageType = FXData.EBSMessageType;
            requestData.SourceID = Settings.Source;
           
            
            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Info(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + FXData.ToString());

            var client = new ApexServices.FXRates.Bank_Biztalk_FXServices_orcProcessRateEnquiry_FXRequestPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.FXRates(requestData);
            var foo = new JavaScriptSerializer().Serialize(returnValue);
            LogHelper.Info(Log, "Response Data " + foo );

            stop.Stop();

            
            LogHelper.Info(Log, "JSON Response Data " + new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue });
            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Data.FXRatesEnquiryRequest>(data);
        }
    }
}