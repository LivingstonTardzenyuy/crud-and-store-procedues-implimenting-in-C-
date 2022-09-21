using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMELECDB.General
{
    public class AppConnection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["comeLec"].ConnectionString;
        }
    }
}
