using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;


namespace ApexServices.Models.ServiceCall
{
    public class AccountTransfer : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var transferData = (Models.Data.AccountTransferRequest)data;
            var requestData = new ApexServices.AccountTransfer.AccountTransferEngage();

            requestData.MessageID = transferData.EBSMessageID;
            requestData.MessageType = transferData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            requestData.WorkstationID = Settings.Workstation;

            /* CPDR01 */
            requestData.EBSUserID = transferData.EBSUserId;
            /* CPDR01 */

            requestData.BeneficiaryName = transferData.BeneficiaryName;
            requestData.BeneficiaryReference = transferData.BeneficiaryReference;
            requestData.ChargeAmount = transferData.ChargeAmount;
            requestData.ChargeCode = transferData.ChargeCode;
            requestData.CreditAccountNumber = transferData.CreditAccountNo;
            requestData.CreditSystemParameter = transferData.CreditSystemParameter;
            requestData.DebitAccountNumber = transferData.DebitAccountNo;
            requestData.DebitSystemParameter = transferData.DebitSystemParameter;
            requestData.ExchangeRate = transferData.ExchangeRate;
            requestData.NarrativeLine1 = transferData.NarrativeLine1;
            requestData.NarrativeLine2 = transferData.NarrativeLine2;
            requestData.NarrativeLine3 = transferData.NarrativeLine3;
            requestData.NarrativeLine4 = transferData.NarrativeLine4;
            requestData.OverrideUser = transferData.OverrideUser;
            requestData.Spare1 = transferData.Spare1;
            requestData.Spare2 = transferData.Spare2;
            requestData.Spare3 = transferData.Spare3;
            requestData.Spare4 = transferData.Spare4;
            requestData.Spare5 = transferData.Spare5;
            requestData.TransferAmount = transferData.TransactionAmount;
            requestData.TransferCurrency = transferData.TransactionCurrency;
            requestData.TransferDueDate = transferData.TransferDueDate;
            requestData.TransferFromAccountNo = transferData.TransferFromAccountNo;
            requestData.TransferReference = transferData.TransactionReference;
            requestData.TransferToAccountNo = transferData.TransferToAccountNo;
            requestData.TransferToSortCode = transferData.TransferToSortcode;
            requestData.TransferType = transferData.TransferType;

            /* CPDR ??? */
            requestData.NoticeWithdrawalType = transferData.NoticeWithdrawalType;
            requestData.NoticeGivenDate = transferData.NoticeGivenDate;
            requestData.NoticeMaturityDate = transferData.NoticeMaturityDate;
            requestData.CloseNoticeAccount = transferData.CloseNoticeAccount;
            /* CPDR ??? */

            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + transferData.ToString());

            var service = new ApexServices.AccountTransfer.BB_Services_EngageServices_orcAccountTransferEngage_ReceiveAccountTransferEngagePortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returndata = service.AccountTransferEngage(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returndata };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Models.Data.AccountTransferRequest>(data);
        }
    }
}