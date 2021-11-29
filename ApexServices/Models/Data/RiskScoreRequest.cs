using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    
    public class RiskScoreRequest
    {
        public String SFDCID { get; set; }
        public String EBSID { get; set; }
        public String PanopticID { get; set; }
        public String RequestType { get; set; }
        public String EntityType { get; set; }
        public String Gender { get; set; }
        public String Salutation { get; set; }
        public String FirstName { get; set; }
        public String MiddleName { get; set; }
        public String LastName { get; set; }
        public String CompanyName { get; set; }
        public String CountryOfBirth { get; set; }
        public String CountryOfNationality { get; set; }
        public String CountryOfResidence { get; set; }
        public String CustomerType { get; set; }
        public String ShippingCountry { get; set; }
        public String PersonMailingCountry { get; set; }
        public String Branch { get; set; }
        public String Product { get; set; }
        public String OrganisationDomicle { get; set; }
        public String NatureOfBusiness { get; set; }
        public String SizeOfBusiness { get; set; }
        public String Country { get; set; }
        public String EmployementType { get; set; }
        public String NatureOfEmployersYourBusiness { get; set; }
        public String EmployerCountry { get; set; }
        public String Ifdualnationalitycountyoforigin { get; set; }
        public String PEP { get; set; }
        public String VIP { get; set; }
        public String HighNetWorth { get; set; }
        public String UltraHighNetWorth { get; set; }
        public String PEPAssociate { get; set; }
        public String Whatisyourtotalnetworth { get; set; }
        public String InternationalFundTransferFrequency { get; set; }
        public String InternationalFundTransferSource { get; set; }
        public String InternationalFundTransferDestination { get; set; }
        public String HighRiskConnectedCountry1 { get; set; }
        public String HighRiskConnectedCountry2 { get; set; }
        public String HighRiskConnectedCountry3 { get; set; }
        public String NumberOfPEPAssociates { get; set; }
        public String HighRiskInternetBankingLocation1 { get; set; }
        public String HighRiskInternetBankingLocation2 { get; set; }
        public String HighRiskInternetBankingLocation3 { get; set; }
        public String SourceOfWealth { get; set; }
        public String SourceOfFunds { get; set; }
        public String SourseOfFundsCountry { get; set; }
        public String EstimatedMonthlyVolumeInward { get; set; }
        public String EstimatedMonthlyNumberOfTransactionsInward { get; set; }
        public String EstimatedMonthlyVolumeOutward { get; set; }
        public String EstimatedMonthlyNumberOfTransactionsOutward { get; set; }
        public String EstimatedCashWithdrawalFrequency { get; set; }
        public String EstimatedCashDepositFrequency { get; set; }
    }
}