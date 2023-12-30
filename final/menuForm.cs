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
    public partial class menuForm : Form
    {
        private TaskScheduler taskScheduler;
        private final.Task selectedTask; // Use the full namespace for your custom Task class
        private updateForm form1Instance;

        public menuForm()
        {
            InitializeComponent();
            taskScheduler = new TaskScheduler(); // Initialize TaskScheduler
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var newform = new addForm(taskScheduler);
            newform.Show();
        }

        private void displaybtn_Click(object sender, EventArgs e)
        {
            var newform = new displayForm(taskScheduler);
            newform.Show();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            final.Task selectedTask = taskScheduler.GetTasks().FirstOrDefault(); // Modify as needed

            if (selectedTask != null)
            {
                var newform = new Form1(selectedTask);
                newform.Show();

                // Optionally refresh the display or perform any other necessary actions after the update
                // For example: taskScheduler.DisplayTasks();
            }
            else
            {
                MessageBox.Show("No task selected for update.");
            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var newform = new delete(taskScheduler);
            newform.Show();
        }
    }
}
