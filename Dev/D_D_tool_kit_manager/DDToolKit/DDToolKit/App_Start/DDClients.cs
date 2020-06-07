using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDToolKit.App_Start
{
    class DDClients
    {
        public static string ClientId = System.Web.Configuration.WebConfigurationManager.AppSettings["goClient"];
       public static string ClientSecret = System.Web.Configuration.WebConfigurationManager.AppSettings["goclientSecret"];
    }
}