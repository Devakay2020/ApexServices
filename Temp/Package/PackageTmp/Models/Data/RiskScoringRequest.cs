using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
   
    public class RiskScoringRequest : EBSBaseRequest
    {
        public String Opportunity { get; set; }
        public List<RiskScoreRequest> RiskScoreRequest {get; set;}
    }
}