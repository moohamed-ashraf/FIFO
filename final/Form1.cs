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
    //update form
    public partial class Form1 : Form
    {
        private TaskScheduler taskScheduler;
        private Task taskToupdate;

        public Form1(final.Task tasktoupdate)
        {
            InitializeComponent();
            taskToupdate = tasktoupdate;
            this.taskScheduler = new TaskScheduler();
            InitializeControls();
            newtaskname.Text = string.Empty;
            newpirority.Text = string.Empty;
            newdeadline.Text = string.Empty;
        }
        private void InitializeControls()
        {
            // Set the ComboBox data source to the list of tasks
            RefreshComboBox();

            // Set default values for other controls
            newtaskname.Text = string.Empty;
            newpirority.Text = string.Empty;
            
            newdeadline.Text = string.Empty;

        }
        private void RefreshComboBox()
        {
            List<Task> tasks = taskScheduler.GetTasks().ToList();
            taskcombobox.DataSource = tasks;
            taskcombobox.DisplayMember = "Name"; // Display the task names in the ComboBox
            taskcombobox.ValueMember = "Name"; // Use the Name property as the value
            taskcombobox.Items.Add(tasks);
        }


        private void DisplaySelectedTaskDetails()
        {
            Task selectedTask = taskcombobox.SelectedItem as Task;

            if (selectedTask != null)
            {
                // Display the selected task details in the form
                taskToupdate = selectedTask;
                newtaskname.Text = taskToupdate.Name;
                newpirority.Text = taskToupdate.Priority.ToString();
                newdeadline.Text = taskToupdate.Deadline.ToString("yyyy-MM-dd HH:mm");
            }
            else
            {
                MessageBox.Show("Please select a task for search.");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //////
        }

       
        private void updatebtn_Click(object sender, EventArgs e)
        {

            if (taskcombobox.SelectedItem is Task selectedTask)
            {
                UpdateTaskProperties(selectedTask);
            }
            else
            {
                MessageBox.Show("No task selected.");
            }
        }
        private void UpdateTaskProperties(Task tasktoupdate)
        {

            taskToupdate.Name = newtaskname.Text;

            if (int.TryParse(newpirority.Text, out int priority))
            {
                taskToupdate.Priority = priority;
            }
            else
            {
                MessageBox.Show("Invalid priority. Please enter a number.");
                return;
            }

            if (DateTime.TryParse(newdeadline.Text, out DateTime deadline))
            {
                taskToupdate.Deadline = deadline;
            }
            else
            {
                MessageBox.Show("Invalid date format. Please enter in the format YYYY-MM-DD HH:MM.");
                return;
            }

            // Update the ComboBox data source after adding a new task
            RefreshComboBox();

            MessageBox.Show("Task updated successfully.");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}

