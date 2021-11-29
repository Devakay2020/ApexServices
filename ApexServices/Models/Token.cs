using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ApexServices.TokenService;
using NLog;

namespace ApexServices.Models
{
    public class Token
    {
        public static string _token { get; set; }
        public static string _source { get; set; }
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        public static bool Check(String source, String token,String address)
        {
            /* C0225
            return true;

            if (_token != null && _source != null)
            {
                if (_token == token && _source == source)
                    return true;
            }
             * */

            LogHelper.Trace(Log, "About to validate token " + token + " - " + source + " - " + address);
            var service = new TokenServiceSoapClient();
            var valid = service.Validate(1, source, token, address, null);
            LogHelper.Trace(Log, "Validated token " + token + " - " + source + " - " + address + " - valid = " + valid.ToString());
            if (valid)
            {
                _token = token;
                _source = source;
            }
            return valid;
        }
    }
}