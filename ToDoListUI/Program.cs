using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListLibrary;

namespace ToDoListUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            GlobalConfig.InitializeConnections(DatabaseType.Sql);
            Application.Run(new ToDoListViewerForm());
        }
    }
}
