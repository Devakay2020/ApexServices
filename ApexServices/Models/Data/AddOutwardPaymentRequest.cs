using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class AddOutwardPaymentRequest : EBSBaseRequest
    {
        public String AmountType { get; set; }
        public String AccountWithInstitution { get; set; }
        public String AccountWithInstitutionAddressLine1 { get; set; }
        public String AccountWithInstitutionAddressLine2 { get; set; }
        public String AccountWithInstitutionAddressLine3 { get; set; }
        public String AccountWithInstitutionAddressLine4 { get; set; }
        public String AccountWithInstitutionBIC { get; set; }
        public String BankOperationCode { get; set; }
        public String BeneficiaryAccountNo { get; set; }
        public String BeneficiarySortCode { get; set; }
        public String BeneficiaryAddressLine1 { get; set; }
        public String BeneficiaryAddressLine2 { get; set; }
        public String BeneficiaryAddressLine3 { get; set; }
        public String BeneficiaryAddressLine4 { get; set; }
        public String BeneficiaryBIC { get; set; }
        public String ChargeAmount { get; set; }
        public String ChargeCode { get; set; }
        public String ChargesFor { get; set; }
        public String CreditSystemParameter { get; set; }
        public String CustomerName { get; set; }
        public String DebitSystemParameter { get; set; }
        public String FinanceEBSProductCode { get; set; }
        public String InstructedAmount { get; set; }
        public String IntermediaryAccount { get; set; }
        public String IntermediaryAddressLine1 { get; set; }
        public String IntermediaryAddressLine2 { get; set; }
        public String IntermediaryAddressLine3 { get; set; }
        public String IntermediaryAddressLine4 { get; set; }
        public String IntermediaryBIC { get; set; }
        public String OpportunityId { get; set; }
        public String OrderingCustomerAccount { get; set; }
        public String OverrideUser { get; set; }
        public String PaymentAmount { get; set; }
        public String PaymentCharges { get; set; }
        public String PaymentCurrency { get; set; }
        public String PaymentDetailsLine1 { get; set; }
        public String PaymentDetailsLine2 { get; set; }
        public String PaymentDetailsLine3 { get; set; }
        public String PaymentDetailsLine4 { get; set; }
        public String PaymentPayValueDate { get; set; }
        public String PaymentRecValueDate { get; set; }
        public String PaymentTransferMethod { get; set; }
        public String PaymentType { get; set; }
        public String PropertyAddress { get; set; }
        public String SenderToReceiveInfoLine1 { get; set; }
        public String SenderToReceiveInfoLine2 { get; set; }
        public String SenderToReceiveInfoLine3 { get; set; }
        public String SenderToReceiveInfoLine4 { get; set; }
        public String SenderToReceiveInfoLine5 { get; set; }
        public String SenderToReceiveInfoLine6 { get; set; }
        public String SolicitorName { get; set; }
        public String DebitAccountNo { get; set; }
        public String CreditAccountNo { get; set; }
        public String Spare1 { get; set; }
        public String Spare2 { get; set; }
        public String Spare3 { get; set; }
        public String Spare4 { get; set; }
        public String Spare5 { get; set; }
        public String TemplateId { get; set; }
    }
}