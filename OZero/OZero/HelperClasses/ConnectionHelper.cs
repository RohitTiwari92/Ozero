using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace OZero.HelperClasses
{
    public static class ConnectionHelper
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}