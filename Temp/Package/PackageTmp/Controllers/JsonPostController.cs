/* --------------------------------------------------------------------- */
/* C0225    Validate Transaction Id                                      */
/* --------------------------------------------------------------------- */


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using ApexServices.Models;
using ApexServices.Models.Data;
using LoggerDLL.nlogService;
using Newtonsoft.Json;
using NLog;
/* C0225 */
using System.Web;
using System.Web.Configuration;
using ApexServices.Models.Data;


namespace ApexServices.Controllers
{
    public class JsonPostController : ApiController
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();

        //public JsonResponse Get(String messageType)
        public JsonResponse Get()
        {
            
            //var d1 = new BaseRequest()
            //        {
            //            ServiceName = id,
            //            Source = "SFDC",
            //            Token = "4f39fe13-e7af-4523-95a2-7d3df9246b98",
            //            User = "Luke"
            //            * C0225 *
            //           // , MessageId = "foo";
            //        };

            var head = Request.Headers;

            var bum = Request.Headers.GetValues("Source");
            var bumf = bum.FirstOrDefault();
            System.Diagnostics.Trace.Write("E = " + bumf.ToString());

            var ood = Request.Headers.GetValues("Token");
            var oodf = ood.FirstOrDefault();
            System.Diagnostics.Trace.Write("E = " + oodf.ToString());

            foreach (var header in head)
            {

                System.Diagnostics.Trace.Write("C = " + header.Key + " D = " + header.Value );
            }

            var d = new BaseRequestGET();
            d.Token = oodf;
            d.Source = bumf;
            //d.ServiceName = messageType;
            var foo = Request.GetQueryNameValuePairs();
            foreach (var blah in foo)
            {
                System.Diagnostics.Trace.Write("A = " + blah.Key + " B = " + blah.Value);
                
                switch (blah.Key)
                {
                    case "ServiceName":
                        d.ServiceName = blah.Value;
                        break;

                    //case "Token":
                    //    d.Token = blah.Value;
                    //    break;

                    //case "Source":
                    //    d.Source = blah.Value;
                    //    break;
                    case "User":
                        d.User = blah.Value;
                        break;

                    case "MessageId":
                        d.MessageId = blah.Value;
                        break;

                    case "Authenticated":
                        d.Authenticated = System.Convert.ToBoolean(blah.Value);
                        break;

                    case "EBSUserId":
                        d.EBSUserId = blah.Value;
                        break;

                    case "EBSMessageType":
                        d.EBSMessageType = blah.Value;
                        break;

                    case "EBSMessageId":
                        d.EBSMessageId = blah.Value;
                        break;

                    case "CustomerId":
                        d.CustomerId = blah.Value;
                        break;

                    //case "ServiceName":
                    //    d.ServiceName = blah.Value;
                    //    break;

                    default :
                        break;
                }
            }
             

            var s = new JavaScriptSerializer().Serialize(d);
            System.Diagnostics.Trace.Write("This is s " + s);
            return Process(s);
        }

        public JsonResponse Post([FromBody] string value)
        {
            var address = ((System.Web.HttpContextWrapper)Request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            var bum = Request.Headers.GetValues("Source");
            var source = bum.FirstOrDefault();
            System.Diagnostics.Trace.Write("F = " + source.ToString());

            var ood = Request.Headers.GetValues("Token");
            var token = ood.FirstOrDefault();
            System.Diagnostics.Trace.Write("G = " + token.ToString());

            return Process(value, token, source, address);
            
        }


        public JsonResponse Process(string value)
        {
            LogHelper.Warn(Log, "This is the value " + value);
            //value = HttpUtility.JavaScriptStringEncode(value);
            //LogHelper.Warn(Log, "This is the value II - " + value);
            var address = ((System.Web.HttpContextWrapper)Request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            var requestId = Guid.NewGuid().ToString();


            MappedDiagnosticsContext.Set("sessionid", requestId);

            var stop = new Stopwatch();
            stop.Start();
            var res = new JsonResponse();
            try
            {
                var data = new JavaScriptSerializer().Deserialize<BaseRequest>(value);
                try
                {
                    LogHelper.Warn(Log, "About to call Check token " + data.Token + " - " + data.Source + " - " + address);

                    if (Models.Token.Check(data.Source, data.Token, address))
                    {
                        //if (data.RequestId == null)

                        //data.RequestId = requestId;

                        /* C0225 start */

                        //bool authenticateCheck = System.Convert.ToBoolean(WebConfigurationManager.AppSettings.Get("UseAuthenticationService"));
                       
                            //string transactionId = GetTransactionId(value);
                            /* C0225
                            if (!String.IsNullOrEmpty(data.MessageId))
                            {
                             */
                       
                        bool authenticated = false;
                        res = ProcessRequest.Process(data.ServiceName, value, data.MessageId, ref authenticated);

                        LogHelper.Info(Log, "Got response from service class " + res.Data.ToString() + " - " + res.ToString());
                            /* C0225        
                            }
                            else
                            {
                                res = ProcessRequest.Process(data.ServiceName, value);
                            }
                            
                        }
                        else
                        {
                            res = ProcessRequest.Process(data.ServiceName, value);
                        }
                        * C0225 end */

                        res.ServiceName = data.ServiceName;
                        // C0225 res.RequestId = data.RequestId;
                        res.Authenticated = authenticated;
                        
                    }
                    else
                    {
                        res.Error = "Invalid token/source";
                        LogHelper.Warn(Log, res.Error);
                    }
                }
                catch (Exception ex)
                {
                    res.Error = ex.Message;
                    if (ex.InnerException != null)
                        res.Error += ex.InnerException.Message;
                    LogHelper.FatalException(Log, res.Error, ex);
                }
                res.MessageId = data.MessageId;
            }
            catch (Exception ex)
            {
                res.Error = "Error serializing data:" + value;
                LogHelper.FatalException(Log,res.Error,ex);
            }

            stop.Stop();
            
            res.Duration = stop.ElapsedMilliseconds.ToString();
            LogHelper.Info(Log, "Duration:" + res.Duration);
            //LogHelper.Info(Log, "Return object : " + new JavaScriptSerializer().Serialize(res));
            return res;
        }

        public JsonResponse Process(string value, string token, string source, string address)
        {
            LogHelper.Warn(Log, "This is the value " + value);
            //value = HttpUtility.JavaScriptStringEncode(value);
            //LogHelper.Warn(Log, "This is the value II - " + value);
            //var address = ((System.Web.HttpContextWrapper)Request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            var requestId = Guid.NewGuid().ToString();


            MappedDiagnosticsContext.Set("sessionid", requestId);

            var stop = new Stopwatch();
            stop.Start();
            var res = new JsonResponse();
            try
            {
                var data = new JavaScriptSerializer().Deserialize<BaseRequest>(value);
                try
                {
                    LogHelper.Warn(Log, "About to call Check token " + token + " - " + source + " - " + address);

                    if (Models.Token.Check(source, token, address))
                    {
                        //if (data.RequestId == null)

                        //data.RequestId = requestId;

                        /* C0225 start */

                        //bool authenticateCheck = System.Convert.ToBoolean(WebConfigurationManager.AppSettings.Get("UseAuthenticationService"));

                        //string transactionId = GetTransactionId(value);
                        /* C0225
                        if (!String.IsNullOrEmpty(data.MessageId))
                        {
                         */

                        bool authenticated = false;
                        res = ProcessRequest.Process(data.ServiceName, value, data.MessageId, ref authenticated);

                        LogHelper.Info(Log, "Got response from service class " + res.Data.ToString() + " - " + res.ToString());
                        /* C0225        
                        }
                        else
                        {
                            res = ProcessRequest.Process(data.ServiceName, value);
                        }
                            
                    }
                    else
                    {
                        res = ProcessRequest.Process(data.ServiceName, value);
                    }
                    * C0225 end */

                        res.ServiceName = data.ServiceName;
                        // C0225 res.RequestId = data.RequestId;
                        res.Authenticated = authenticated;

                    }
                    else
                    {
                        res.Error = "Invalid token/source";
                        LogHelper.Warn(Log, res.Error);
                    }
                }
                catch (Exception ex)
                {
                    res.Error = ex.Message;
                    if (ex.InnerException != null)
                        res.Error += ex.InnerException.Message;
                    LogHelper.FatalException(Log, res.Error, ex);
                }
                res.MessageId = data.MessageId;
            }
            catch (Exception ex)
            {
                res.Error = "Error serializing data:" + value;
                LogHelper.FatalException(Log, res.Error, ex);
            }

            stop.Stop();

            res.Duration = stop.ElapsedMilliseconds.ToString();
            LogHelper.Info(Log, "Duration:" + res.Duration);
            //LogHelper.Info(Log, "Return object : " + new JavaScriptSerializer().Serialize(res));
            return res;
        }

        
    }
}