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
    public partial class addForm : Form
    {
        private TaskScheduler task;
        public addForm(TaskScheduler scheduler)
        {
            InitializeComponent();
            task = scheduler;
        }


        private void addtaskbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string taskName = taskname.Text;
                int priority;
                DateTime deadline;

                

                while (!int.TryParse(prioritytxt.Text, out priority) || priority < 1 || priority > 5)
                {
                    MessageBox.Show("Invalid priority. Please enter a number between 1 and 5.");
                    return; // Exit the method if priority is invalid
                }

                while (!DateTime.TryParse(deadlinetxt.Text, out deadline))
                {
                    MessageBox.Show("Invalid date format. Please enter in the format YYYY-MM-DD HH:MM.");
                    return; // Exit the method if the deadline is invalid
                }
                while (deadline < DateTime.Now)
                {
                    MessageBox.Show("This date is in the past,please enter a valid date");
                    return;
                }

                task.AddTask(taskName, priority, deadline);
                MessageBox.Show("Task added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taskname.Text = deadlinetxt.Text = prioritytxt.Text = null;
               // Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
