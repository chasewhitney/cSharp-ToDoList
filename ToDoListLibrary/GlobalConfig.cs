using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListLibrary.DataAccess;

namespace ToDoListLibrary
{
    public static class GlobalConfig
    {
        public const string TasksFile = "TasksModels.csv";

        /// <summary>
        /// Connection will be Class SqlConnector or TextConnector depending upon
        /// GlobalConfig.InitializeConnections(DatabaseType.TYPE) in Program.cs
        /// </summary>
        public static IDataConnection Connection { get; private set; }

        /// <summary>
        /// Sets Connection to be Class SqlConnector or TextConnector
        /// </summary>
        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                Connection = new SqlConnector();
            }
            else if (db == DatabaseType.Text)
            {
                Connection = new TextConnector();
            }
        }

        /// <summary>
        /// String used to connect to SQL database
        /// </summary>
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
