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
    public partial class delete : Form
    {
        private TaskScheduler taskScheduler;
        private Task taskToDelete;

        public delete(TaskScheduler scheduler)
        {
            InitializeComponent();
            taskScheduler = scheduler;
            taskToDelete = null;
            InitializeControls();
        }
        private void InitializeControls()
        {
            // Set textboxes with task properties
            if (taskToDelete != null)
            {
                tasknamesearchtxt1.Text = taskToDelete.Name;
              
            }
            else
            {
                tasknamesearchtxt1.Text = string.Empty;
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         private void searchbtn_Click(object sender, EventArgs e)
        {
            // Perform the search based on the entered task name
            string searchName = tasknamesearchtxt1.Text;

            if (!string.IsNullOrEmpty(searchName))
            {
                Task foundTask = taskScheduler.GetTasks().FirstOrDefault(task => task.Name == searchName);

                if (foundTask != null)
                {
                    // Display the found task in the form
                    taskToDelete = foundTask;
                    InitializeControls();
                }
                else
                {
                    MessageBox.Show($"Task with name '{searchName}' not found.");
                    taskToDelete = null;
                    InitializeControls();
                }
            }
            else
            {
                MessageBox.Show("Please enter a task name for search.");
            }
        }


        private void delete_Load(object sender, EventArgs e)
        {
            if (taskToDelete != null)
            {
                // Delete the found task
               taskScheduler.DeleteTask();
                MessageBox.Show("Task deleted successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No task selected for deletion. Perform a search first.");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

  
}
        
    


