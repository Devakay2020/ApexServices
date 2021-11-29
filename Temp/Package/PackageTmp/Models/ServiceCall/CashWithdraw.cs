using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class CashWithdraw : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var withdrawData = (Models.Data.CashWithdrawRequest) data;
            var requestData = new ApexServices.CashWithdrawal.CashWithdrawal();

            requestData.MessageID = withdrawData.EBSMessageID;
            requestData.MessageType = withdrawData.EBSMessageType;
            requestData.EBSUserID = withdrawData.EBSUserId;
            requestData.SourceID = Settings.Source;
            requestData.WorkstationID = Settings.Workstation;

            requestData.CreditAccountNumber = withdrawData.CreditAccountNo;
            requestData.DebitAccountNumber = withdrawData.DebitAccountNo;
            requestData.ChargeAmount = withdrawData.ChargeAmount;
            requestData.ChargeCode = withdrawData.ChargeCode;
            requestData.CreditSystemParameter = withdrawData.CreditSystemParameter;
            requestData.DebitSystemParameter = withdrawData.DebitSystemParameter;
            requestData.OverrideUser = withdrawData.OverrideUser;
            requestData.PostToCashAccount = withdrawData.PostToCashAccount;
            requestData.Spare1 = withdrawData.Spare1;
            requestData.Spare2 = withdrawData.Spare2;
            requestData.Spare3 = withdrawData.Spare3;
            requestData.Spare4 = withdrawData.Spare4;
            requestData.Spare5 = withdrawData.Spare5;
            requestData.TransactionAmount = withdrawData.TransactionAmount;
            requestData.TransactionCurrency = withdrawData.TransactionCurrency;
            requestData.TransactionNarrativeLine1 = withdrawData.NarrativeLine1;
            requestData.TransactionNarrativeLine2 = withdrawData.NarrativeLine2;
            requestData.TransactionNarrativeLine3 = withdrawData.NarrativeLine3;
            requestData.TransactionNarrativeLine4 = withdrawData.NarrativeLine4;
            requestData.TransactionReference = withdrawData.TransactionReference;
            requestData.ValueDate = withdrawData.ValueDate;

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + requestData.ToString());

            var client = new ApexServices.CashWithdrawal.BB_Services_EngageServices_orcCashWithdrawal_ReceiveCashWithdrawalRequestPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.CashWithdrawal(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Models.Data.CashWithdrawRequest>(data);
        }
    }
}