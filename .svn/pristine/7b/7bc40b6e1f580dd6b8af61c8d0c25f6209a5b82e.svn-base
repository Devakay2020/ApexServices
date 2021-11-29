using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.DirectDebit;
using ApexServices.Models.Data;

namespace ApexServices.Models.ServiceCall
{
    public class DirectDebit : IServiceCall
    {
        public JsonResponse Process(object data)
        {
            var objData = (DirectDebitRequest)data;
            var acc = new IBBAccountDD { AccountNo = objData.AccountId, SourceID = Settings.Source, WorkstationID = Settings.Workstation };

            var service = new BBWebServices_AccountDD_AccountDDOrch_AccountDD_PortSoapClient ();
            var stop = new Stopwatch();
            stop.Start();

            var returndata = service.AccountDDOrch(acc);
            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returndata.DDResult };
        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<DirectDebitRequest>(data);
        }
    }
}