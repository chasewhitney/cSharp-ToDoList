using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListLibrary.Models;

namespace ToDoListLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        // Completed, Name, Id
        // TasksFile.csv
        // C:\data\TournamentTracker

        public void CreateTask(TaskModel model)
        {
            List<TaskModel> tasks = GlobalConfig.TasksFile.FullFilePath().LoadFile().ConvertToTaskModels();

            tasks.Add(model);

            List<string> lines = new List<string>();

            foreach (TaskModel tm in tasks)
            {
                lines.Add($"{ tm.Id },{ tm.Name },{ tm.Completed }");
            }

            File.WriteAllLines(GlobalConfig.TasksFile.FullFilePath(), lines);
        }

        public void DeleteTask(TaskModel model)
        {
            throw new NotImplementedException();
        }

        public List<TaskModel> GetTask_All()
        {
            List<TaskModel> tasks = GlobalConfig.TasksFile.FullFilePath().LoadFile().ConvertToTaskModels();

            return tasks;
        }

        public void UpdateTask(TaskModel model)
        {
            throw new NotImplementedException();
        }

    }
}
