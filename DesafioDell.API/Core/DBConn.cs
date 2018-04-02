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
            
            string dbname = "Desd";

            if (string.IsNullOrEmpty(dbname)) return null;

            string username = "desd";
            string password = "projetodell123";
            string hostname = "desd.cc91hmnfqyj6.us-east-2.rds.amazonaws.com";
            string port = "1433";

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }


    }
}
