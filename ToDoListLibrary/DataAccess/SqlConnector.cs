using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListLibrary.Models;

namespace ToDoListLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {
        private const string db = "ToDoList";

        public void CreateTask(TaskModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", model.Name);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTasks_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public List<TaskModel> GetTask_All()
        {
            List<TaskModel> output;

            // Stored procedure is omitting completed tasks
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TaskModel>("dbo.spTasks_GetAll").ToList();
            }

            return output;
        }

        public void DeleteTask(TaskModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.Id);
                connection.Execute("dbo.Tasks_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateTask(TaskModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.Id);
                p.Add("@Name", model.Name);
                p.Add("@Completed", model.Completed);
                connection.Execute("dbo.spTasks_Update", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
