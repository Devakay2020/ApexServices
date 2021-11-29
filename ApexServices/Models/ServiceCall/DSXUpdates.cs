using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;
using System.Collections.Generic;


namespace ApexServices.Models.ServiceCall
{
   
    public class DSXUpdates : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            LogHelper.Trace(Log, "Into Process for DSXUpdates : " + data.ToString());

            var depositData = (Models.Data.DSXUpdateRequests)data;
            LogHelper.Trace(Log, "Before Assign A : " + depositData.ToString());

            //depositData.DSXUpdRequests

            var requestData = new ApexServices.DSXUpdates.DSXUpdateRequests();
            //requestData.


            List<ApexServices.DSXUpdates.DSXUpdateRequest> DSXList = new List<ApexServices.DSXUpdates.DSXUpdateRequest>();
            LogHelper.Trace(Log, "Before Assign B : " + requestData.ToString());

            
                        
            foreach (Models.Data.DSXUpdateRequest updData in depositData.DSXUpdRequests)
            {
                ApexServices.DSXUpdates.DSXUpdateRequest reqData = new ApexServices.DSXUpdates.DSXUpdateRequest();
                reqData.AccountNo = updData.AccountNo; 
                reqData.ActionStatus = updData.ActionStatus;
                reqData.Branch = updData.Branch;
                reqData.BufferID = updData.BufferID;
                reqData.CaseReference = updData.CaseReference;
                reqData.CompletionDate = updData.CompletionDate;
                reqData.CustomerNo = updData.CustomerNo;
                reqData.DocumentDate = updData.DocumentDate;
                reqData.DocumentName = updData.DocumentName;
                reqData.DocumentReference = updData.DocumentReference;
                reqData.DocumentTime = updData.DocumentTime;
                reqData.DocumentUDI = updData.DocumentUDI;
                reqData.FirstName = updData.FirstName;
                reqData.LastName = updData.LastName;
                reqData.PostCode = updData.PostCode;
                reqData.ProcessStatus = updData.ProcessStatus;
                reqData.WorkLocation = updData.WorkLocation;
                DSXList.Add(reqData);
            }

            requestData.DSXUpdRequests = DSXList.ToArray();

            LogHelper.Trace(Log, "Request data before serialiser : " + requestData.ToString());
            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + requestData.ToString());

            var client = new ApexServices.DSXUpdates.DSXUpdateServiceSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.UpdatesDSX(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            LogHelper.Trace(Log, "About to parse " + data);
            return new JavaScriptSerializer().Deserialize<Models.Data.DSXUpdateRequests>(data);
        }
    }
     
}