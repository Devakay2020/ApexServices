using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;

namespace ApexServices.Models.ServiceCall
{
    public class AddOutwardPayment : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var addOutwardPaymentData = (AddOutwardPaymentRequest)data;
            var requestData = new ApexServices.AddOutwardPayment.AddOutwardPaymentEngage();

            requestData.MessageID = addOutwardPaymentData.EBSMessageID;
            requestData.MessageType = addOutwardPaymentData.EBSMessageType;
            requestData.SourceID = Settings.Source;
            requestData.WorkstationID = Settings.Workstation;

            /* CPDR 01 */
            requestData.EBSUserID = addOutwardPaymentData.EBSUserId;
            /* CPDR01 */

            requestData.CreditAccountNumber = addOutwardPaymentData.CreditAccountNo;
            requestData.DebitAccountNumber = addOutwardPaymentData.DebitAccountNo;
            requestData.AmountType = addOutwardPaymentData.AmountType;
            requestData.AccountWithInstitutionAcct = addOutwardPaymentData.AccountWithInstitution;
            requestData.AccountWithInstitutionAddL1 = addOutwardPaymentData.AccountWithInstitutionAddressLine1;
            requestData.AccountWithInstitutionAddL2 = addOutwardPaymentData.AccountWithInstitutionAddressLine2;
            requestData.AccountWithInstitutionAddL3 = addOutwardPaymentData.AccountWithInstitutionAddressLine3;
            requestData.AccountWithInstitutionAddL4 = addOutwardPaymentData.AccountWithInstitutionAddressLine4;
            requestData.AccountWithInstitutionBIC = addOutwardPaymentData.AccountWithInstitutionBIC;
            requestData.BankOperationCode = addOutwardPaymentData.BankOperationCode;
            requestData.BeneficiaryAcctNo = addOutwardPaymentData.BeneficiaryAccountNo;
            requestData.BeneficiarySortCode = addOutwardPaymentData.BeneficiarySortCode;
            requestData.BeneficiaryAddressLine1 = addOutwardPaymentData.BeneficiaryAddressLine1;
            requestData.BeneficiaryAddressLine2 = addOutwardPaymentData.BeneficiaryAddressLine2;
            requestData.BeneficiaryAddressLine3 = addOutwardPaymentData.BeneficiaryAddressLine3;
            requestData.BeneficiaryAddressLine4 = addOutwardPaymentData.BeneficiaryAddressLine4;
            requestData.BeneficiaryBIC = addOutwardPaymentData.BeneficiaryBIC;
            requestData.ChargeAmount = addOutwardPaymentData.ChargeAmount;
            requestData.ChargeCode = addOutwardPaymentData.ChargeCode;
            requestData.ChargesFor = addOutwardPaymentData.ChargesFor;
            requestData.CreditSystemParameter = addOutwardPaymentData.CreditSystemParameter;
            requestData.CustomerName = addOutwardPaymentData.CustomerName;
            requestData.DebitSystemParameter = addOutwardPaymentData.DebitSystemParameter;
            requestData.FinanceEBSProductCode = addOutwardPaymentData.FinanceEBSProductCode;
            requestData.InstructedAmount = addOutwardPaymentData.InstructedAmount;
            requestData.IntermediaryAcct = addOutwardPaymentData.IntermediaryAccount;
            requestData.IntermediaryAddressLine1 = addOutwardPaymentData.IntermediaryAddressLine1;
            requestData.IntermediaryAddressLine2 = addOutwardPaymentData.IntermediaryAddressLine2;
            requestData.IntermediaryAddressLine3 = addOutwardPaymentData.IntermediaryAddressLine3;
            requestData.IntermediaryAddressLine4 = addOutwardPaymentData.IntermediaryAddressLine4;
            requestData.IntermediaryBIC = addOutwardPaymentData.IntermediaryBIC;
            requestData.OpportunityID = addOutwardPaymentData.OpportunityId;
            requestData.OrderingCustomerAcct = addOutwardPaymentData.OrderingCustomerAccount;
            requestData.OverrideUser = addOutwardPaymentData.OverrideUser;
            requestData.PaymentAmount = addOutwardPaymentData.PaymentAmount;
            requestData.PaymentCharges = addOutwardPaymentData.PaymentCharges;
            requestData.PaymentCurrency = addOutwardPaymentData.PaymentCurrency;
            requestData.PaymentDetailsLine1 = addOutwardPaymentData.PaymentDetailsLine1;
            requestData.PaymentDetailsLine2 = addOutwardPaymentData.PaymentDetailsLine2;
            requestData.PaymentDetailsLine3 = addOutwardPaymentData.PaymentDetailsLine3;
            requestData.PaymentDetailsLine4 = addOutwardPaymentData.PaymentDetailsLine4;
            requestData.PaymentPayValueDate = addOutwardPaymentData.PaymentPayValueDate;
            requestData.PaymentRecValueDate = addOutwardPaymentData.PaymentRecValueDate;
            requestData.PaymentTransferMethod = addOutwardPaymentData.PaymentTransferMethod;
            requestData.PaymentType = addOutwardPaymentData.PaymentType;
            requestData.PropertyAddress = addOutwardPaymentData.PropertyAddress;
            requestData.SenderToReceiverInfoL1 = addOutwardPaymentData.SenderToReceiveInfoLine1;
            requestData.SenderToReceiverInfoL2 = addOutwardPaymentData.SenderToReceiveInfoLine2;
            requestData.SenderToReceiverInfoL3 = addOutwardPaymentData.SenderToReceiveInfoLine3;
            requestData.SenderToReceiverInfoL4 = addOutwardPaymentData.SenderToReceiveInfoLine4;
            requestData.SenderToReceiverInfoL5 = addOutwardPaymentData.SenderToReceiveInfoLine5;
            requestData.SenderToReceiverInfoL6 = addOutwardPaymentData.SenderToReceiveInfoLine6;
            requestData.SolicitorName = addOutwardPaymentData.SolicitorName;
            requestData.Spare1 = addOutwardPaymentData.Spare1;
            requestData.Spare2 = addOutwardPaymentData.Spare2;
            requestData.Spare3 = addOutwardPaymentData.Spare3;
            requestData.Spare4 = addOutwardPaymentData.Spare4;
            requestData.Spare5 = addOutwardPaymentData.Spare5;
            requestData.TemplateID = addOutwardPaymentData.TemplateId;


            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + addOutwardPaymentData.ToString());

            var client = new ApexServices.AddOutwardPayment.BB_Services_EngageServices_orcAddOutwardPaymentEngage_ReceiveAddOutwardPaymentPortSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.AddOutwardPayment(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<AddOutwardPaymentRequest>(data);
        }
    }
}