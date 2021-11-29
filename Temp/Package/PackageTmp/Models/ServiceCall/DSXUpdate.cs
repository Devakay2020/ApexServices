using System.Diagnostics;
using System.Web.Script.Serialization;
using ApexServices.AccountSummary;
using ApexServices.Models.Data;
using NLog;


namespace ApexServices.Models.ServiceCall
{
   
    public class DSXUpdate : IServiceCall
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public JsonResponse Process(object data)
        {
            LogHelper.Trace(Log, "Into Process for DSXUpdate : " + data.ToString());
            var depositData = (Models.Data.DSXUpdateRequest)data;
            LogHelper.Trace(Log, "Before Assign A : " + depositData.ToString());
            var requestData = new ApexServices.DSXUpdate.DSXUpdateRequest();
            LogHelper.Trace(Log, "Before Assign  B : " + requestData.ToString());
            requestData.MessageID = depositData.EBSMessageID;
            requestData.MessageType = depositData.EBSMessageType;
            //requestData.EBSUserID = depositData.EBSUserId;
            //requestData.SourceID = Settings.Source;
            //requestData.WorkstationID = Settings.Workstation;

            requestData.AccountNo = depositData.AccountNo; ;
            requestData.ActionStatus = depositData.ActionStatus;
            requestData.Branch = depositData.Branch;
            requestData.BufferID = depositData.BufferID;
            requestData.CaseReference = depositData.CaseReference;
            requestData.CompletionDate = depositData.CompletionDate;
            requestData.CustomerNo = depositData.CustomerNo;
            requestData.DocumentDate = depositData.DocumentDate;
            requestData.DocumentName = depositData.DocumentName;
            requestData.DocumentReference = depositData.DocumentReference;
            requestData.DocumentTime = depositData.DocumentTime;
            requestData.DocumentUDI = depositData.DocumentUDI;
            requestData.FirstName = depositData.FirstName;
            requestData.LastName = depositData.LastName;
            requestData.PostCode = depositData.PostCode;
            requestData.ProcessStatus = depositData.ProcessStatus;
            requestData.WorkLocation = depositData.WorkLocation;

            LogHelper.Trace(Log, "Request data before serialiser : " + requestData.ToString());
            var requestJson = new JavaScriptSerializer().Serialize(requestData);
            LogHelper.Trace(Log, "Request data : " + requestJson);
            LogHelper.Info(Log, "About to send request, request params are : " + requestData.ToString());

            var client = new ApexServices.DSXUpdate.DSXUpdateServiceSoapClient();

            var stop = new Stopwatch();
            stop.Start();

            var returnValue = client.UpdateDSX(requestData);

            stop.Stop();

            return new JsonResponse() { CalloutDuration = stop.ElapsedMilliseconds.ToString(), Data = returnValue };
        }

        public object ParseData(string data)
        {
            LogHelper.Trace(Log, "About to parse " + data);
            return new JavaScriptSerializer().Deserialize<Models.Data.DSXUpdateRequest>(data);
        }
    }
     
}