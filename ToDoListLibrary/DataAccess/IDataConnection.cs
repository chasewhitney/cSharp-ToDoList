using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListLibrary.Models;

namespace ToDoListLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateTask(TaskModel model);
        List<TaskModel> GetTask_All();
        void DeleteTask(TaskModel model);
        void UpdateTask(TaskModel model);
    }
}
