using System;

namespace FoxCo
{
    class ImportantCode
    {
        //This holds the current version number of the program
        public String versionNumber()
        {
            String version = "V0.1";
            return version;
        }

        //This holds the connection string for the database so it only has to be updated
        // in a single location
        public string dbConnection()
        {
            string dbConnection = @"|DataDirectory|\db\FOXCO.MDF";

            return dbConnection;
        }
    }
}
