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
            int currentId = 1;

            if (tasks.Count > 0)
            {
                currentId = tasks.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

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
            List<TaskModel> tasks = GlobalConfig.TasksFile.FullFilePath().LoadFile().ConvertToTaskModels();

            TaskModel taskToRemove = tasks.Single(x => x.Id == model.Id);

            tasks.Remove(taskToRemove);

            List<string> lines = new List<string>();

            foreach (TaskModel tm in tasks)
            {
                lines.Add($"{ tm.Id },{ tm.Name },{ tm.Completed }");
            }

            File.WriteAllLines(GlobalConfig.TasksFile.FullFilePath(), lines);

        }

        public List<TaskModel> GetTask_All()
        {
            List<TaskModel> tasks = GlobalConfig.TasksFile.FullFilePath().LoadFile().ConvertToTaskModels();

            // Currently omitting completed tasks
            tasks.RemoveAll(x => x.Completed);

            return tasks;
        }

        public void UpdateTask(TaskModel model)
        {
            List<TaskModel> tasks = GlobalConfig.TasksFile.FullFilePath().LoadFile().ConvertToTaskModels();

            int indexToUpdate = tasks.FindIndex(x => x.Id == model.Id);

            tasks[indexToUpdate] = model;

            List<string> lines = new List<string>();

            foreach (TaskModel tm in tasks)
            {
                lines.Add($"{ tm.Id },{ tm.Name },{ tm.Completed }");
            }

            File.WriteAllLines(GlobalConfig.TasksFile.FullFilePath(), lines);
        }

    }
}
