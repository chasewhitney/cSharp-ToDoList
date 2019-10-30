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
    public partial class ToDoListViewerForm : Form, IEditRequester
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
            if (ValidateForm())
            {
                TaskModel t = new TaskModel();

                t.Name = addTaskBox.Text;

                GlobalConfig.Connection.CreateTask(t);

                allTasks.Add(t);

                addTaskBox.Text = "";
                WireUpLists();
            } else
            {
                MessageBox.Show("Invalid entry. Please enter text.");
            }


        }

        private void completeTaskButton_Click(object sender, EventArgs e)
        {
            TaskModel t = (TaskModel)taskListBox.SelectedItem;

            t.Completed = true;

            GlobalConfig.Connection.UpdateTask(t);

            allTasks.Remove(t);

            WireUpLists();
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            TaskModel t = (TaskModel)taskListBox.SelectedItem;

            GlobalConfig.Connection.DeleteTask(t);

            allTasks.Remove(t);

            WireUpLists();
        }

        private void editTaskButton_Click(object sender, EventArgs e)
        {
            TaskModel t = (TaskModel)taskListBox.SelectedItem;

            TaskEditForm frm = new TaskEditForm(this, t);
            frm.Show();
        }

        public void EditComplete(TaskModel model)
        {
            GlobalConfig.Connection.UpdateTask(model);

            allTasks.Remove(allTasks.Where(x => x.Id == model.Id).First());            

            allTasks.Add(model);

            allTasks = allTasks.OrderBy(x => x.Id).ToList();

            WireUpLists();
        }

        private bool ValidateForm()
        {
            bool output = true;

            if(addTaskBox.Text == null || addTaskBox.Text == "")
            {
                output = false;
            }

            return output;
        }
    }
}
