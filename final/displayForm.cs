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
    public partial class displayForm : Form
    {
        private TaskScheduler taskScheduler;

        public displayForm(TaskScheduler scheduler)
        {
            InitializeComponent();
            taskScheduler = scheduler;
            DisplayTasks();
        }
        private void DisplayTasks()
        {
            // Assuming you have a DataGridView named dataGridView1 on your form
            dataGridView1.Rows.Clear();

            List<Task> sortedTasks = new List<Task>(taskScheduler.GetTasks());

            // Sort tasks by deadline and then priority
            sortedTasks.Sort((task1, task2) =>
            {
                int deadlineCompare = task1.Deadline.CompareTo(task2.Deadline);
                if (deadlineCompare == 0)
                {
                    return task1.Priority.CompareTo(task2.Priority);
                }
                return deadlineCompare;
            });

            foreach (var task in sortedTasks)
            {
                dataGridView1.Rows.Add(task.Name, task.Priority, task.Deadline);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Task> taskList = taskScheduler.GetTasks().ToList();

            // Check if the index is within the bounds of the list
            if (e.RowIndex >= 0 && e.RowIndex < taskList.Count)
            {
                Task selectedTask = taskList[e.RowIndex];

                // Create and show the updateForm
                using (updateForm Form1 = new updateForm(selectedTask))
                {
                    Form1.ShowDialog();
                }

                // Refresh the display after updating
                DisplayTasks();
            }

        }
    }
}
