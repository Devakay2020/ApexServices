using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Web;


namespace ApexServices.Models.ServiceCall
{
    public class RiskScoring : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var riskData = (Data.RiskScoringRequest)data;
            var requestData = new ApexServices.RiskScoring.SFDCRiskRequests();
            
            //var[] requestList = new ApexServices.RiskScoring.SFDCRiskRequestsRiskScoreRequest();
            

            requestData.MessageID = riskData.EBSMessageID;
            requestData.MessageType = riskData.EBSMessageType;
            //requestData.EBSUserID = riskData.EBSUserId;
            requestData.SourceID = Settings.Source;
            requestData.Opportunity = riskData.Opportunity;

            

            //requestData.WorkstationID = Settings.Workstation;
            List<ApexServices.RiskScoring.SFDCRiskRequestsRiskScoreRequest> riskScoreRequestList = new List<ApexServices.RiskScoring.SFDCRiskRequestsRiskScoreRequest>();
           
            foreach (Data.RiskScoreRequest req in riskData.RiskScoreRequest)
            {
                ApexServices.RiskScoring.SFDCRiskRequestsRiskScoreRequest riskReq = new ApexServices.RiskScoring.SFDCRiskRequestsRiskScoreRequest();

                riskReq.Branch = req.Branch;
                riskReq.CompanyName = req.CompanyName;
                riskReq.Country = req.Country;
                riskReq.CountryOfBirth = req.CountryOfBirth;
                riskReq.CountryOfNationality = req.CountryOfNationality;
                riskReq.CountryOfResidence = req.CountryOfResidence;
                riskReq.CustomerType = req.CustomerType;
                riskReq.EBSID = req.EBSID;
                riskReq.EmployementType = req.EmployementType;
                riskReq.EmployerCountry = req.EmployerCountry;
                riskReq.EntityType = req.EntityType;
                riskReq.EstimatedCashDepositFrequency = req.EstimatedCashDepositFrequency;
                riskReq.EstimatedCashWithdrawalFrequency = req.EstimatedCashWithdrawalFrequency;
                riskReq.EstimatedMonthlyNumberOfTransactionsInward = req.EstimatedMonthlyNumberOfTransactionsInward;
                riskReq.EstimatedMonthlyNumberOfTransactionsOutward = req.EstimatedMonthlyNumberOfTransactionsOutward;
                riskReq.EstimatedMonthlyVolumeInward = req.EstimatedMonthlyVolumeInward;
                riskReq.EstimatedMonthlyVolumeOutward = req.EstimatedMonthlyVolumeOutward;
                riskReq.FirstName = req.FirstName;
                riskReq.Gender = req.Gender;
                riskReq.HighNetWorth = req.HighNetWorth;
                riskReq.HighRiskConnectedCountry1 = req.HighRiskConnectedCountry1;
                riskReq.HighRiskConnectedCountry2 = req.HighRiskConnectedCountry2;
                riskReq.HighRiskConnectedCountry3 = req.HighRiskConnectedCountry3;
                riskReq.HighRiskInternetBankingLocation1 = req.HighRiskInternetBankingLocation1;
                riskReq.HighRiskInternetBankingLocation2 = req.HighRiskInternetBankingLocation2;
                riskReq.HighRiskInternetBankingLocation3 = req.HighRiskInternetBankingLocation3;
                riskReq.Ifdualnationalitycountyoforigin = req.Ifdualnationalitycountyoforigin;
                riskReq.InternationalFundTransferDestination = req.InternationalFundTransferDestination ;
                riskReq.InternationalFundTransferFrequency = req.InternationalFundTransferFrequency;
                riskReq.InternationalFundTransferSource = req.InternationalFundTransferSource;
                riskReq.LastName = req.LastName;
                riskReq.MiddleName = req.MiddleName;
                riskReq.NatureOfBusiness = req.NatureOfBusiness;
                riskReq.NatureOfEmployersYourBusiness = req.NatureOfEmployersYourBusiness;
                riskReq.NumberOfPEPAssociates = req.NumberOfPEPAssociates;
                riskReq.OrganisationDomicle = req.OrganisationDomicle;
                riskReq.PanopticID = req.PanopticID;
                riskReq.PEP = req.PEP;
                riskReq.PEPAssociate = req.PEPAssociate;
                riskReq.PersonMailingCountry = req.PersonMailingCountry;
                riskReq.Product = req.Product;
                riskReq.RequestType = req.RequestType;
                riskReq.Salutation = req.Salutation;
                riskReq.SFDCID = req.SFDCID;
                riskReq.ShippingCountry = req.ShippingCountry;
                riskReq.SizeOfBusiness = req.SizeOfBusiness;
                riskReq.SourceOfFunds = req.SourceOfFunds;
                riskReq.SourceOfWealth = req.SourceOfWealth;
                riskReq.SourseOfFundsCountry = req.SourseOfFundsCountry;
                riskReq.UltraHighNetWorth = req.UltraHighNetWorth;
                riskReq.VIP = req.VIP;
                riskReq.Whatisyourtotalnetworth = req.Whatisyourtotalnetworth;
 
                riskScoreRequestList.Add(riskReq);
            }
            
            //requestList = riskScoreRequestList.ToArray();
            requestData.RiskScoreRequest = riskScoreRequestList.ToArray(); 

            LogHelper.Info(Log, "About to serialise request A, request params are : " + requestData.ToString());
            //requestData.RiskScoreRequest = riskScoreRequestList.ToArray();
            LogHelper.Info(Log, "About to serialise request, request params are : " + requestData.ToString());
            //requestData = HttpUtility.JavaScriptStringEncode(requestData);
            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + requestData.ToString());

            var client = new ApexServices.RiskScoring.Bank_Biztalk_RiskScoring_orcProcessPanoptic_ReceiveSFDCRequestPortClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.PanopticRequest(requestData);
            LogHelper.Info(Log, "About to send response, request params are : " + returnValue.ToString());
            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Models.Data.RiskScoringRequest>(data);
        }
    }
}