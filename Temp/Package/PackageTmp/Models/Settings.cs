using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ApexServices.Models
{
    public class Settings
    {
        public static String Source
        {
            get { return WebConfigurationManager.AppSettings["MessageSource"]; }
        }

        public static String Workstation
        {
            get { return WebConfigurationManager.AppSettings["Workstation"]; }
        }

    }
}