using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using ApexServices.DirectDebit;
using ApexServices.DirectDebitCancel;
using ApexServices.Models.Data;

namespace ApexServices.Models.ServiceCall
{
    public class DirectDebitCancel : IServiceCall
    {
        public JsonResponse Process(object data)
        {
            var objData = (DirectDebitCancelRequest)data;
            var acc = new CancelDirectDebit{ AccountNo = objData.AccountId, SourceID = Settings.Source, WorkstationID = Settings.Workstation, DDReference  = objData.DDRef };


            var service = new BB_Services_CashierServices_orcCancelDirectDebit_ReceiveCancelDirectDebitPortSoapClient();
            var stop = new Stopwatch();
            stop.Start();

            var returndata = service.CancelDirectDebit(acc);
            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returndata };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<DirectDebitCancelRequest>(data);
        }
    }
}