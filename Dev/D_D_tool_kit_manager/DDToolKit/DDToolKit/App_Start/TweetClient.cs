using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDToolKit.App_Start
{
    public class TweetClient
    {
        public static string consumerKey = System.Web.Configuration.WebConfigurationManager.AppSettings["tKey"];
        public static string consumerSecret = System.Web.Configuration.WebConfigurationManager.AppSettings["tSecret"];
    }
}