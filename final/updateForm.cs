using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class updateForm : Form
    {
        private TaskScheduler taskScheduler;
        private Task taskToUpdate;

        public updateForm(Task task)
        {
            InitializeComponent();
            taskToUpdate = task;
            InitializeControls();
        }
        private void InitializeControls()
        {
            // Set textboxes with task properties
            if (taskToUpdate != null)
            {
                newnametxt.Text = taskToUpdate.Name;
                prioritytxt.Text = taskToUpdate.Priority.ToString();
                deadlinetxt.Text = taskToUpdate.Deadline.ToString("yyyy-MM-dd HH:mm");
                newnametxt.Text=tasknamesearchtxt.Text = deadlinetxt.Text = prioritytxt.Text = null;
            }
            else
            {
                tasknamesearchtxt.Text = deadlinetxt.Text = prioritytxt.Text = string.Empty;
            }
        }
        private void updatetaskbstn_Click(object sender, EventArgs e)
        {
           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void updateForm_Load(object sender, EventArgs e)
        {

        }

        private void updatetaskbtn_Click(object sender, EventArgs e)
        {
         // Update task properties

            taskToUpdate.Name = tasknamesearchtxt.Text;

            if (int.TryParse(prioritytxt.Text, out int priority))
            {
                taskToUpdate.Priority = priority;
            }
            else
            {
                MessageBox.Show("Invalid priority. Please enter a number.");
                return;
            }

            if (DateTime.TryParse(deadlinetxt.Text, out DateTime deadline))
            {
                taskToUpdate.Deadline = deadline;
            }
            else
            {
                MessageBox.Show("Invalid date format. Please enter in the format YYYY-MM-DD HH:MM.");
                return;
            }

            MessageBox.Show("Task updated successfully.");
            //this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prioritytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void deadlinetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void taskname_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}
