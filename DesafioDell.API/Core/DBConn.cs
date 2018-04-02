using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DesafioDell.Data
{
    public class DBConn
    {
        public static string GetRDSConnectionString()
        {
            //var appConfig = ConfigurationManager.AppSettings;

            string dbname = "Desd";//appConfig["RDS_DB_NAME"];

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = "desd";// appConfig["RDS_USERNAME"];
            string password = "projetodell123";// appConfig["RDS_PASSWORD"];
            string hostname = "desd.cc91hmnfqyj6.us-east-2.rds.amazonaws.com";// appConfig["RDS_HOSTNAME"];
            string port = "1433";// appConfig["RDS_PORT"];

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }


    }
}
