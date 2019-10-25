using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListLibrary.DataAccess;

namespace ToDoListLibrary
{
    public static class GlobalConfig
    {

        public static IDataConnection Connection { get; private set; }

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
    }
}
