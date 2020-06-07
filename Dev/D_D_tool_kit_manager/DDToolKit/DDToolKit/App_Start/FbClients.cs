using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDToolKit.App_Start
{
    public class FbClients
    {
        public static string appId = System.Web.Configuration.WebConfigurationManager.AppSettings["fbappId"];
        public static string appSecret = System.Web.Configuration.WebConfigurationManager.AppSettings["fbSecret"];

    }
}