using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HistoricalTrackingDemoLibrary.DAL
{
    public static class ConnectionString
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }
    }
}
