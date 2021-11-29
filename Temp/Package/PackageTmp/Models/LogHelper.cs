using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;

namespace ApexServices.Models
{
    public static class LogHelper
    {
        public static void Log(Logger logger, string msg, LogLevel level)
        {
            LogEventInfo p = LogEventInfo.Create(level, logger.Name, msg);
            if (MappedDiagnosticsContext.Contains("sessionid"))
            {
                string id = MappedDiagnosticsContext.Get("sessionid");
                p.Properties.Add("sessionid", id);
            }
            logger.Log(p);
        }

        public static void LogException(Logger logger, string msg, LogLevel level, Exception ex)
        {
            LogEventInfo p = LogEventInfo.Create(level, logger.Name, msg, ex);
            if (MappedDiagnosticsContext.Contains("sessionid"))
            {
                string id = MappedDiagnosticsContext.Get("sessionid");
                p.Properties.Add("sessionid", id);
            }
            logger.Log(p);
        }

        public static void Fatal(Logger logger, string msg)
        {
            Log(logger, msg, LogLevel.Fatal);
        }

        public static void Error(Logger logger, string msg)
        {
            Log(logger, msg, LogLevel.Error);
        }

        public static void Warn(Logger logger, string msg)
        {
            Log(logger, msg, LogLevel.Warn);
        }

        public static void Info(Logger logger, string msg)
        {
            Log(logger, msg, LogLevel.Info);
        }

        public static void Debug(Logger logger, string msg)
        {
            Log(logger, msg, LogLevel.Debug);
        }

        public static void Trace(Logger logger, string msg)
        {
            Log(logger, msg, LogLevel.Trace);
        }


        public static void FatalException(Logger logger, string msg, Exception ex)
        {
            LogException(logger, msg, LogLevel.Fatal, ex);
        }

        public static void ErrorException(Logger logger, string msg, Exception ex)
        {
            LogException(logger, msg, LogLevel.Error, ex);
        }

        public static void WarnException(Logger logger, string msg, Exception ex)
        {
            LogException(logger, msg, LogLevel.Warn, ex);
        }

        public static void InfoException(Logger logger, string msg, Exception ex)
        {
            LogException(logger, msg, LogLevel.Info, ex);
        }

        public static void DebugException(Logger logger, string msg, Exception ex)
        {
            LogException(logger, msg, LogLevel.Debug, ex);
        }

        public static void TraceException(Logger logger, string msg, Exception ex)
        {
            LogException(logger, msg, LogLevel.Trace, ex);
        }
    }
}