using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class DigitalBankingRequest
    {
        public String Action { get; set; }
        public String EBSID { get; set; }
    }
}