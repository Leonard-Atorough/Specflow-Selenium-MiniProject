using System;
using System.Configuration;

namespace SauceDemo_WebTest
{
    public static class AppConfigReader
    {

        //public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string ProductPageUrl = ConfigurationManager.AppSettings["productpage_url"];

    }
}