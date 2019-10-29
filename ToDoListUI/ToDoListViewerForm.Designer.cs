namespace ToDoListUI
{
    partial class ToDoListViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskListLabel = new System.Windows.Forms.Label();
            this.taskListBox = new System.Windows.Forms.ListBox();
            this.addTaskBox = new System.Windows.Forms.TextBox();
            this.completeTaskButton = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskListLabel
            // 
            this.taskListLabel.AutoSize = true;
            this.taskListLabel.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskListLabel.Location = new System.Drawing.Point(274, 27);
            this.taskListLabel.Name = "taskListLabel";
            this.taskListLabel.Size = new System.Drawing.Size(260, 106);
            this.taskListLabel.TabIndex = 0;
            this.taskListLabel.Text = "ToDo!";
            // 
            // taskListBox
            // 
            this.taskListBox.FormattingEnabled = true;
            this.taskListBox.ItemHeight = 37;
            this.taskListBox.Location = new System.Drawing.Point(78, 153);
            this.taskListBox.Name = "taskListBox";
            this.taskListBox.Size = new System.Drawing.Size(653, 374);
            this.taskListBox.TabIndex = 1;
            // 
            // addTaskBox
            // 
            this.addTaskBox.Location = new System.Drawing.Point(78, 590);
            this.addTaskBox.Name = "addTaskBox";
            this.addTaskBox.Size = new System.Drawing.Size(653, 43);
            this.addTaskBox.TabIndex = 2;
            // 
            // completeTaskButton
            // 
            this.completeTaskButton.Location = new System.Drawing.Point(763, 153);
            this.completeTaskButton.Name = "completeTaskButton";
            this.completeTaskButton.Size = new System.Drawing.Size(170, 61);
            this.completeTaskButton.TabIndex = 3;
            this.completeTaskButton.Text = "Complete";
            this.completeTaskButton.UseVisualStyleBackColor = true;
            this.completeTaskButton.Click += new System.EventHandler(this.completeTaskButton_Click);
            // 
            // editTaskButton
            // 
            this.editTaskButton.Location = new System.Drawing.Point(763, 378);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(170, 61);
            this.editTaskButton.TabIndex = 4;
            this.editTaskButton.Text = "Edit";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.editTaskButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.Location = new System.Drawing.Point(763, 466);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(170, 61);
            this.deleteTaskButton.TabIndex = 5;
            this.deleteTaskButton.Text = "Delete";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(763, 581);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(170, 61);
            this.addTaskButton.TabIndex = 6;
            this.addTaskButton.Text = "Add";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // ToDoListViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 755);
            this.Controls.Add(this.addTaskButton);
            this.Controls.Add(this.deleteTaskButton);
            this.Controls.Add(this.editTaskButton);
            this.Controls.Add(this.completeTaskButton);
            this.Controls.Add(this.addTaskBox);
            this.Controls.Add(this.taskListBox);
            this.Controls.Add(this.taskListLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ToDoListViewerForm";
            this.Text = "ToDo List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskListLabel;
        private System.Windows.Forms.ListBox taskListBox;
        private System.Windows.Forms.TextBox addTaskBox;
        private System.Windows.Forms.Button completeTaskButton;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button addTaskButton;
    }
}