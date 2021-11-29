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
    public class AS400GetTemplates : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        public Data.JsonResponse Process(object data)
        {
            LogHelper.Info(Log, "Request data : " + data);
            var stop = new Stopwatch();
            stop.Start();

            var client = new EBSData.EbsDataSoapClient();
            var response = client.GetA400Templates();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = response };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Data.AS400GetTemplatesRequest>(data);
        }
    }
}