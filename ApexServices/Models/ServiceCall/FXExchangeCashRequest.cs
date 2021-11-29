/* ---------------------------------------------------------------------------------------------------------------- */
/* C0???   New FX Message                                                                                */
/* ---------------------------------------------------------------------------------------------------------------- */

using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class FXExchangeCashRequest : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var FXData = (Data.FXExchangeCashRequest)data;
            var requestData = new ApexServices.FXExchangeCash.ExchangeCashEngage();

            requestData.MessageID = FXData.EBSMessageID;
            requestData.MessageType = FXData.EBSMessageType;
            requestData.SourceID = Settings.Source;

            requestData.BuyAmount = FXData.BuyAmount;
            requestData.BuyCurrency = FXData.BuyCurrency;
            requestData.SellAmount = FXData.SellAmount;
            requestData.SellCurrency = FXData.SellCurrency;


            requestData.CreditSystemParameter = FXData.CreditSystemParameter;
            
            
            requestData.DebitSystemParameter = FXData.DebitSystemParameter;
            requestData.EBSUserID = FXData.EBSUserId;
            requestData.ExchangeRate = FXData.ExchangeRate;
            
            requestData.OverrideUser = FXData.OverrideUser;
            requestData.Spare1 = FXData.Spare1;
            requestData.Spare2 = FXData.Spare2;
            requestData.Spare3 = FXData.Spare3;
            requestData.Spare4 = FXData.Spare4;
            requestData.Spare5 = FXData.Spare5;
            requestData.TransactionNarrativeLine1 = FXData.TransactionNarrativeLine1;
            requestData.TransactionNarrativeLine2 = FXData.TransactionNarrativeLine2;
            requestData.TransactionNarrativeLine3 = FXData.TransactionNarrativeLine3;
            requestData.TransactionNarrativeLine4 = FXData.TransactionNarrativeLine4;
            requestData.TransactionReference = FXData.TransactionReference;
            requestData.ValueDate = FXData.ValueDate;

            requestData.RoundingBuyCurrency = FXData.RoundingBuyCurrency;
            requestData.RoundingSellCurrency = FXData.RoundingSellCurrency;
            requestData.RoundingBuyAmount = FXData.RoundingBuyAmount;
            requestData.RoundingSellAmount = FXData.RoundingSellAmount;
 
            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + FXData.ToString());

            var client = new ApexServices.FXExchangeCash.Bank_Biztalk_FXServices_orcProcessFXExchangeCash_ReceiveFXExchangeCashPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.FXExchangeCash(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Data.FXExchangeCashRequest>(data);
        }
    }
}