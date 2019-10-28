using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListLibrary;
using ToDoListLibrary.Models;

namespace ToDoListUI
{
    public partial class ToDoListViewerForm : Form
    {
        List<TaskModel> allTasks = GlobalConfig.Connection.GetTask_All();

        public ToDoListViewerForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            taskListBox.DataSource = null;

            taskListBox.DataSource = allTasks;
            taskListBox.DisplayMember = "Name";
        }


        private void addTaskButton_Click(object sender, EventArgs e)
        {
            // TODO - Validate new task input

            TaskModel t = new TaskModel();

            t.Name = addTaskBox.Text;

            GlobalConfig.Connection.CreateTask(t);

            allTasks.Add(t);

            addTaskBox.Text = "";
            WireUpLists();
        }

        private void completeTaskButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            TaskModel t = (TaskModel)taskListBox.SelectedItem;

            GlobalConfig.Connection.DeleteTask(t);

            allTasks.Remove(t);

            WireUpLists();
        }
    }
}
