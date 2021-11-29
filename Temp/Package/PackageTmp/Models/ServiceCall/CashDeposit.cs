using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;


namespace ApexServices.Models.ServiceCall
{
    public class CashDeposit : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var depositData = (Data.CashDepositRequest)data;
            var requestData = new ApexServices.CashDeposit.CashDeposit();

            requestData.MessageID = depositData.EBSMessageID;
            requestData.MessageType = depositData.EBSMessageType;
            requestData.EBSUserID = depositData.EBSUserId;
            requestData.SourceID = Settings.Source;
            requestData.WorkstationID = Settings.Workstation;

            requestData.CreditAccountNumber = depositData.CreditAccountNo;
            requestData.DebitAccountNumber = depositData.DebitAccountNo;
            requestData.ChargeAmount = depositData.ChargeAmount;
            requestData.ChargeCode = depositData.ChargeCode;
            requestData.CreditSystemParameter = depositData.CreditSystemParameter;
            requestData.DebitSystemParameter = depositData.DebitSystemParameter;
            requestData.OverrideUser = depositData.OverrideUser;
            requestData.PostToCashAccount = depositData.PostToCashAccount;
            requestData.TransactionAmount = depositData.TransactionAmount;
            requestData.TransactionReference = depositData.TransactionReference;
            requestData.TransactionCurrency = depositData.TransactionCurrency;
            requestData.ValueDate = depositData.ValueDate;
            requestData.TransactionNarrativeLine1 = depositData.NarrativeLine1;
            requestData.TransactionNarrativeLine2 = depositData.NarrativeLine2;
            requestData.TransactionNarrativeLine3 = depositData.NarrativeLine3;
            requestData.TransactionNarrativeLine4 = depositData.NarrativeLine4;

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + requestData.ToString());

            var client = new ApexServices.CashDeposit.BB_Services_EngageServices_orcCashDeposit_ReceiveCashDepositRequestPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.CashDeposit(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Models.Data.CashDepositRequest>(data);
        }
    }
}