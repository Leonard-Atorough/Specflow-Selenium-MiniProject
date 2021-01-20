using System;
using System.Configuration;

namespace SauceDemo_WebTest
{
    public static class AppConfigReader
    {
        public static readonly string SignInPageUrl = ConfigurationManager.AppSettings["signinpage_url"];
    }
}