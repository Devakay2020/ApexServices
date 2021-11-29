/* ----------------------------------------------------------------------- */
/* C0225    
/* ----------------------------------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using ApexServices.Models.Data;
using LoggerDLL.nlogService;
using NLog;
using System.Web.Configuration;

namespace ApexServices.Models
{
    public class ProcessRequest 
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

       
        public static JsonResponse Process(String messageType,String data)
        {

            IServiceCall call = null;
            try
            {
                call = (IServiceCall)Activator.CreateInstance(Type.GetType("ApexServices.Models.ServiceCall."+messageType));
            }
            catch (Exception ex)
            {
                LogHelper.FatalException(Log,"Error trying to create an instance of " + messageType,ex);
                return new JsonResponse(){ServiceName =messageType, Error = string.Format("Could not create instance of {0}",messageType)};
            }


            object parsedJson = null;

            try
            {
                parsedJson = call.ParseData(data);
            }
            catch (Exception ex)
            {
                LogHelper.FatalException(Log, "Error trying to parse the request data into type " + messageType, ex);
                return new JsonResponse() {ServiceName = messageType, Error = string.Format("Could not parse data into instance of {0}", messageType) };
            }


            try
            {
                return call.Process(parsedJson);
            }
            catch (Exception ex)
            {
                
                var response= new JsonResponse() { Error = string.Format("Could not process service call for instance of {0} : {1}", messageType,ex.Message) };
                LogHelper.FatalException(Log, response.Error + messageType, ex);
                return response;
            }
        }

        /* C0225 new constructor so transactionId is available */
        public static JsonResponse Process(String messageType, String data, String transactionId, ref bool authenticated)
        {
           
            IServiceCall call = null;
            try
            {
                string theType = "ApexServices.Models.ServiceCall." + messageType;
                LogHelper.Warn(Log, "This is the Type :" + theType);
                //call = (IServiceCall)Activator.CreateInstance(Type.GetType("ApexServices.Models.ServiceCall." + messageType));
                call = (IServiceCall)Activator.CreateInstance(Type.GetType(theType));
            }
            catch (Exception ex)
            {
                LogHelper.FatalException(Log, "Error trying to create an instance of " + messageType, ex);
                return new JsonResponse() { ServiceName = messageType, Error = string.Format("Could not create instance of {0}", messageType) };
            }


            object parsedJson = null;

            try
            {
                LogHelper.Warn(Log, "This is the Data :" + data);
                
                parsedJson = call.ParseData(data);
                data = HttpUtility.JavaScriptStringEncode(data);
                LogHelper.Warn(Log, "This is the Data II :" + data);
            }
            catch (Exception ex)
            {
                LogHelper.FatalException(Log, "Error trying to parse the request data into type " + messageType, ex);
                return new JsonResponse() { ServiceName = messageType, Error = string.Format("Could not parse data into instance of {0}", messageType) };
            }

                 /* temp hack */

            LogHelper.Info(Log, "This is the Message Type " + messageType + " transaction id = " + transactionId);
            authenticated = true;
            bool authenticateCheck = System.Convert.ToBoolean(WebConfigurationManager.AppSettings.Get("UseAuthenticationService"));
            if (authenticateCheck)
            {
                if (messageType != "AccountSummary")
                {
                    try
                    {
                        ApexServices.CheckAuthentication.AuthenticationCheckSoapClient checkService = new CheckAuthentication.AuthenticationCheckSoapClient();
                        authenticated = checkService.CheckAuthentication(transactionId);

                    }
                    catch (Exception ex2)
                    {
                        authenticated = false;
                        LogHelper.FatalException(Log, "Cannot invoke authentication for " + messageType + " transaction id = " + transactionId, ex2);
                        return new JsonResponse()
                            {
                                ServiceName = messageType,
                                Error = string.Format("Transaction Id cannot be authenticated {0}", transactionId)
                            ,
                                Authenticated = authenticated
                            };
                    }
                }
            }
            /* C0225 */
            
            if (!authenticated)
            {
                LogHelper.FatalException(Log, "Authentication failed for " + messageType + " transaction id = " + transactionId,null);
                return new JsonResponse() 
                { ServiceName = messageType, 
                    Error = string.Format("Transaction Id not authenticated {0}", transactionId)
                    , Authenticated = authenticated
                };
            }
            else
            {
                try
                {
                    
                    return call.Process(parsedJson);
                           
                }
                catch (Exception ex)
                {

                    var response = new JsonResponse() { Error = string.Format("Could not process service call for instance of {0} : {1}", messageType, ex.Message) };
                    LogHelper.FatalException(Log, response.Error + messageType, ex);
                    return response;
                }
            }
        }
    }
}