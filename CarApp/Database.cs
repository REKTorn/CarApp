using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Database
    {
        public SQLiteConnection dbConn;
        private string databaseFilename = "./car.db";

        public Database()
        {
            if(!File.Exists(databaseFilename))
            {
                File.Create(databaseFilename);
            }
            dbConn = new SQLiteConnection("Data Source" + databaseFilename);
        }

        public void OpenConnection()
        {
            if(dbConn.State != System.Data.ConnectionState.Open)
            {
                dbConn.Open();
            }
        }

        public void CloseConnection()
        {
            if(dbConn.State != System.Data.ConnectionState.Closed)
            {
                dbConn.Close();
            }
        }
    }
}
