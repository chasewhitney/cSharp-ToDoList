using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListLibrary.Models;

namespace ToDoListUI
{
    public partial class TaskEditForm : Form
    {
        IEditRequester callingForm;
        TaskModel modelToEdit;

        public TaskEditForm(IEditRequester caller, TaskModel model)
        {
            InitializeComponent();

            callingForm = caller;
            modelToEdit = model;

            editTextBox.Text = modelToEdit.Name;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                modelToEdit.Name = editTextBox.Text;
                callingForm.EditComplete(modelToEdit);

                this.Close();
            } else
            {
                MessageBox.Show("Invalid entry. Please enter text.");
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateForm()
        {
            bool output = true;

            if(editTextBox.Text == null || editTextBox.Text == "")
            {
                output = false;
            }

            return output;
        }
    }
}
