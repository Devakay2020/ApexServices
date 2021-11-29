using System;
using System.Web.Script.Serialization;
using ApexServices.Models.Data;
using ApexServices.svcDataWebservice;

namespace ApexServices.Models.ServiceCall
{
    public class DataWebservice : IServiceCall
    {
        public JsonResponse Process(object data)
        {
            var images = (Models.Data.GetCustomerImageRequest)data;

            var service = new svcDataWebservice.DataWebServiceSoapClient();
            var message = new innerMessage();
            message.MessageID = images.EBSMessageID;
            message.CustomerID = images.CustomerId;
            message.MessageType = "CustomerImages";

            var response = service.GetCustomerImages(message);
            return new JsonResponse() { Data = response };

        }

        public object ParseData(string data)
        {
            return new JavaScriptSerializer().Deserialize<Models.Data.GetCustomerImageRequest>(data);
        }
    }
}