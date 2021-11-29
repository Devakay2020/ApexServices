/* -------------------------------------------------------------------------------------------------------------------- */
/* C0284	Cheque Deposit requires new mapping																			*/
/* -------------------------------------------------------------------------------------------------------------------- */


using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;


namespace ApexServices.Models.ServiceCall
{
    public class ChequeDeposit : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var deposit = (Models.Data.ChequeDepositRequest)data;
            var request = new ApexServices.ChequeDeposit.ChequeDeposit();

            request.MessageID = deposit.EBSMessageID;
            request.MessageType = deposit.EBSMessageType;
            request.EBSUserID = deposit.EBSUserId;
            request.SourceID = Settings.Source;
            request.WorkstationID = Settings.Workstation;

            request.CreditAccountNumber = deposit.CreditAccountNo;
            request.DebitAccountNumber = deposit.DebitAccountNo;
            request.ChargeAmount = deposit.ChargeAmount;
            request.ChargeCode = deposit.ChargeCode;
            request.ChequeAmount = deposit.TransactionAmount;
            request.ChequeCurrency = deposit.TransactionCurrency;
            request.ChequeSerialNo = deposit.ChequeSerialNo;
            request.ChequeType = deposit.ChequeType;
            request.CreditSystemParameter = deposit.CreditSystemParameter;
            request.DebitSystemParameter = deposit.DebitSystemParameter;
            request.DepositReference = deposit.TransactionReference;
            request.IssuingBank = deposit.IssuingBank;
            request.NoOfCheques = deposit.NoOfCheques;
            request.OverrideUser = deposit.OverrideUser;

            /* C0284 fix */
            request.TransactionReference = deposit.TransactionReference;
            request.TransactionNarrativeLine1 = deposit.TransactionNarrativeLine1;
            request.TransactionNarrativeLine2 = deposit.TransactionNarrativeLine2;
            request.TransactionNarrativeLine3 = deposit.TransactionNarrativeLine3;
            request.TransactionNarrativeLine4 = deposit.TransactionNarrativeLine4;
            /* C0284 */

            request.Spare1 = deposit.Spare1;
            request.Spare2 = deposit.Spare2;
            request.Spare3 = deposit.Spare3;
            request.Spare4 = deposit.Spare4;
            request.Spare5 = deposit.Spare5;
            request.ValueDate = deposit.ValueDate;

            var requestJson = new JavaScriptSerializer().Serialize(request);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + deposit.ToString());

            var client = new ApexServices.ChequeDeposit.BB_Services_EngageServices_orcChequeDeposit_ReceiveChequeDepositRequestPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.ChequeDeposit(request);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Models.Data.ChequeDepositRequest>(data);
        }
    }
}