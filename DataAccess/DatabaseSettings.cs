using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class DatabaseSettings
    {
        // This is used to store all settings for TententDB.cs, PropertyDB.cs, LeaseDB.cs
        public static string ApiKey { get; set; }
        public static string ConnectionString { get => connectionString; }

        // Connection String is used to tell C# what and where the database is located and 
        // the credentials for the userID  and password
        // This is needed to connect to the SQL Server, everyone will use this same Connection String
        private static string connectionString =
            "Server=db-nwt-sql-2025.cub0wuxajdbv.us-east-2.rds.amazonaws.com,1433;" +
            "Network Library = DBMSSOCN;" +
            "Initial Catalog = SlumLordRentalsAWS;" +
            "User ID = nwtStudent; Password = nwt123!";
       
    }


