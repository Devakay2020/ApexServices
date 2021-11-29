using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class ChequeWithdrawal : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var withdrawal = (Models.Data.ChequeWithdrawalRequest)data;

            var request = new ApexServices.ChequeWithdrawal.ChequeWithdrawal();
            request.MessageID = withdrawal.EBSMessageID;
            request.MessageType = withdrawal.EBSMessageType;
            request.EBSUserID = withdrawal.EBSUserId;
            request.SourceID = Settings.Source;
            request.WorkstationID = Settings.Workstation;

            request.CreditAccountNumber = withdrawal.CreditAccountNo;
            request.DebitAccountNumber = withdrawal.DebitAccountNo;
            request.ChargeAmount = withdrawal.ChargeAmount;
            request.ChargeCode = withdrawal.ChargeCode;
            request.ChequeSerialNo = withdrawal.ChequeSerialNo;
            request.CreditSystemParameter = withdrawal.CreditSystemParameter;
            request.DebitSystemParameter = withdrawal.DebitSystemParameter;
            request.OverrideUser = withdrawal.OverrideUser;
            request.Spare1 = withdrawal.Spare1;
            request.Spare2 = withdrawal.Spare2;
            request.Spare3 = withdrawal.Spare3;
            request.Spare4 = withdrawal.Spare4;
            request.Spare5 = withdrawal.Spare5;
            request.TransactionAmount = withdrawal.TransactionAmount;
            request.TransactionCurrency = withdrawal.TransactionCurrency; 
            request.TransactionNarrativeLine1 = withdrawal.NarrativeLine1; 
            request.TransactionNarrativeLine2 = withdrawal.NarrativeLine2;
            request.TransactionNarrativeLine3 = withdrawal.NarrativeLine3;
            request.TransactionNarrativeLine4 = withdrawal.NarrativeLine4;
            request.TransactionReference = withdrawal.TransactionReference;
            request.ValueDate = withdrawal.ValueDate;

            var requestJson = new JavaScriptSerializer().Serialize(request);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + withdrawal.ToString());

            var client = new ApexServices.ChequeWithdrawal.BB_Services_EngageServices_orcChequeWithdrawal_RecieveChequeWithdrawalPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.ChequeWithdrawal(request);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Models.Data.ChequeWithdrawalRequest>(data);
        }
    }
}