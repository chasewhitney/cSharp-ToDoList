using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListLibrary.Models;

namespace ToDoListLibrary.DataAccess
{
    public static class ExtensionHelpers
    {
        public static List<TaskModel> ConvertToTaskModels(this List<string> lines)
        {
            List<TaskModel> output = new List<TaskModel>();

            foreach (string line in lines)
            {
                TaskModel tm = new TaskModel();
                string[] cols = line.Split(',');
                tm.Id = int.Parse(cols[0]);
                tm.Name = cols[1];
                tm.Completed = bool.Parse(cols[2]);

                output.Add(tm);
            }

            return output;
        }

        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"] }\\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        
    }
}
