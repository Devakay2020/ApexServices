using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using NLog.Common;
using NLog.Targets;

namespace LoggerDLL
{
    [Target("MyWebService")]
    public class WebnlogServiceger : TargetWithLayout
    {
        public override NLog.Layouts.Layout Layout
        {
            get
            {
                return base.Layout;
            }
            set
            {
                base.Layout = value;
            }
        }

        protected override void Write(LogEventInfo logEvent)
        {
            base.Write(logEvent);
        }

        //NLog.Common.AsyncLogEventInfo

        protected override void Write(AsyncLogEventInfo logEvent)
        {
            // base.Write(logEvent);
            var arr = new NLog.Common.AsyncLogEventInfo[1];
            arr[0] = logEvent;
            Write(arr);
        }
         

        /*
        protected override void Write(AsyncLogEventInfo logEvent)
        {
            base.Write(logEvent);
        }
         */


        protected override void Write(NLog.Common.AsyncLogEventInfo[] logEvents)
        {
            try
            {
                // _log.Fatal("Log called");
                var service = new nlogService.log { Url = Host };

                //  _log.Info("Creating log for {0} events", logEvents.Length);
                var col = new nlogService.LogDataCollection { TableName = Table };

                var l = Layout;

                var list = new List<nlogService.LogData>();
                foreach (var logEvent in logEvents)
                {
                    var item = new nlogService.LogData();
                    item.Date = logEvent.LogEvent.TimeStamp;
                    if (logEvent.LogEvent.Exception != null)
                    {
                        item.Exception = logEvent.LogEvent.Exception.Message;
                        if (logEvent.LogEvent.Exception.StackTrace != null)
                            item.Trace = logEvent.LogEvent.Exception.StackTrace.ToString();

                    }

                    item.Level = logEvent.LogEvent.Level.Name;
                    item.Logger = logEvent.LogEvent.LoggerName;
                    item.Message = logEvent.LogEvent.FormattedMessage;


                    foreach (var prop in logEvent.LogEvent.Properties)
                    {
                        var propKey = prop.Key.ToString().ToUpper();

                        switch (propKey)
                        {
                            case "SESSIONID":
                                item.SessionId = prop.Value.ToString();
                                break;

                            case "XML":
                                item.XML = prop.Value.ToString();
                                break;

                            case "USER":
                                item.User = prop.Value.ToString();
                                break;
                        }
                    }

                    list.Add(item);
                }
                col.LogData = list.ToArray();
                service.AddLogsAsync(col);
            }
            catch (Exception ex)
            {
                //    _log.FatalException("Error sending logs : " + ex.Message ,ex);
            }
        }

        public string Host { get; set; }
        public string Table { get; set; }
        public string SessionId { get; set; }


    }
}

