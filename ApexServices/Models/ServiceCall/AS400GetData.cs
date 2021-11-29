using ApexServices.EBSData;
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
    public class AS400GetData : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        public Data.JsonResponse Process(object data)
        {
            var requestData = (AS400GetDataRequest)data;

            LogHelper.Info(Log, "Request data : " + data);
            var stop = new Stopwatch();
            stop.Start();

            ArrayOfString ar = new ArrayOfString();
            foreach (var item in requestData.Templates)
            {
                ar.Add(item);
                Log.Info("Looking for template:" + item);
            }

            var client = new EBSData.EbsDataSoapClient();
            var response = client.GetData(ar);

            Log.Info("Size of response:" + response.Length);
            var json = new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = response };
            Log.Info("returning:" + json);
            return json;
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<AS400GetDataRequest>(data);
        }
    }
}