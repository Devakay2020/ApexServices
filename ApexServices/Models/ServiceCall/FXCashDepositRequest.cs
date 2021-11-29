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
    public class FXCashDepositRequest : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var FXData = (Data.FXCashDepositRequest)data;
            var requestData = new ApexServices.FXCashDeposit.FXCashDepositEngage();

            requestData.MessageID = FXData.EBSMessageID;
            requestData.MessageType = FXData.EBSMessageType;
            requestData.SourceID = Settings.Source;

            requestData.CreditAccountNumber = FXData.CreditAccountNumber;
            requestData.CreditSystemParameter = FXData.CreditSystemParameter;
            requestData.DebitAccountNumber = FXData.DebitAccountNumber;
            requestData.DepositAmount = FXData.DepositAmount;
            requestData.DepositCurrency = FXData.DepositCurrency;
            requestData.ExchangeCurrency = FXData.ExchangeCurrency;
            requestData.DebitSystemParameter = FXData.DebitSystemParameter;
            requestData.EBSUserID = FXData.EBSUserId;
            requestData.ExchangeRate = FXData.ExchangeRate;
            requestData.ExchangeAmount = FXData.ExchangeAmount;
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
            
            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + FXData.ToString());

            var client = new ApexServices.FXCashDeposit.Bank_Biztalk_FXServices_orcProcessFXCashDeposit_ReceiveFXCashDepositPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.FXCashDeposit(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Data.FXCashDepositRequest>(data);
        }
    }
}