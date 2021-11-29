using ApexServices.Models.Data;
using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace ApexServices.Models.ServiceCall
{
    public class DigitalBanking : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            var requestData = (DigitalBankingRequest)data;

            LogHelper.Trace(Log, "Request data : " + requestData.Action + ":" + requestData.EBSID);
            LogHelper.Info(Log, "About to send request");

            var client = new ApexServices.DigitalBanking.UserManagementSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            object returnValue = null;


            //var f = client.GetUserInfo(requestData.EBSID);


            switch(requestData.Action)
            {
                case  "UserInfo":
                    returnValue = client.GetUserInfo(requestData.EBSID);
                    break;

                case "UserBar":
                    returnValue = client.BarUser(requestData.EBSID);
                    break;

                case "UserUnBar":
                    returnValue = client.UnBarUser(requestData.EBSID);
                    break;

                case "UserUnBlock":
                    returnValue = client.UnBlock(requestData.EBSID);
                    break;

                case "ResetPassword":
                    returnValue = client.ResetPassword(requestData.EBSID);
                    
                    break;

                case "ResetSecret":
                    returnValue = client.ResetSecret(requestData.EBSID);
                    break;

                case "Trans":
                    returnValue = client.GetTransactions(requestData.EBSID);
                    break;

                default:
                    returnValue = null;
                    break;
            }

            //if(requestData.Action == "UserInfo")
            //    returnValue = client.GetUserInfo(requestData.EBSID);
            
            stop.Stop();
            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<DigitalBankingRequest>(data);
        }
    }
}