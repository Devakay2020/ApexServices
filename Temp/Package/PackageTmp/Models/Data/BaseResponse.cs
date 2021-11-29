﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApexServices.Models.Data
{
    public class JsonResponse
    {
            public object Data { get; set; }
            public string ServiceName { get; set; }
            public string Duration { get; set; }
            public string CalloutDuration { get; set; }
            public Boolean Authenticated { get; set; }
            public string Error { get; set; }
            public string LogId { get; set; }
            public String MessageId { get; set; }
            public String RequestId { get; set; }
    }
}