using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using final; // Add this line if menuForm is in the YourNamespace namespace
namespace final
{
   
    
    // Class representing an individual task
    public class Task : IComparable<Task>
    {
        public string Name { get; set; }
        public int Priority { get; set; }
        public DateTime Deadline { get; set; }

        // Constructor to initialize task properties
        public Task(string name, int priority, DateTime deadline)
        {
            this.Name = name;
            this.Priority = priority;
            this.Deadline= deadline;
        }
        public override string ToString()
        {
            return Name;
        }
    

    // method to compare 
    public int CompareTo(Task other)
        {
            // Compare tasks based on deadline
            int deadlineCompare = Deadline.CompareTo(other.Deadline);
            int nameCompare = Name.CompareTo(other.Name);

            if (deadlineCompare == 0)
            {
                return Priority.CompareTo(other.Priority);
            }
            return deadlineCompare;
        }
    }

    // Class representing a task scheduler
    public class TaskScheduler
    {
        private PriorityQueue<Task> taskQueue = new PriorityQueue<Task>();

        // Method to add a new task to the task queue
        public void AddTask(string name, int priority, DateTime deadline)
        {
            Task newTask = new Task(name, priority, deadline);
            taskQueue.Enqueue(newTask);
        }

        public IEnumerable<Task> GetTasks()
        {
            return taskQueue.GetTasks();
        }

        // Method to execute tasks based on the order they were added
        public void ExecuteTasks()
        {
            if (taskQueue.Count == 0)
            {
                Console.WriteLine("No tasks to execute");
            }
            else
            {
                Console.WriteLine("Executing Tasks:");
                Console.WriteLine("---------------");

                while (taskQueue.Count > 0)
                {
                    Task nextTask = taskQueue.Dequeue();
                    Console.WriteLine($"Task: {nextTask.Name}, Priority: {nextTask.Priority}, Deadline: {nextTask.Deadline}");
                }
            }
        }

        public void DisplayTasks()
        {
            List<Task> taskList = new List<Task>(taskQueue.ToArray());

            if (taskQueue.Count == 0)
            {
                Console.WriteLine("There are no tasks.");
            }
            else
            {
                Console.WriteLine("Displaying Tasks (Sorted by Deadline): ");

                // Sort tasks by Deadline using CompareTo method
                taskList.Sort((task1, task2) => task1.CompareTo(task2));

                foreach(Task task in taskList)
                {
                    Console.WriteLine($"Task: {task.Name}, Priority: {task.Priority}, Deadline: {task.Deadline}");
                }
            }
        }

        // Method to update a task's properties
        public void UpdateTask()
        {
            string taskNameToUpdate;
            string newTaskName;
            DateTime newDeadline;

            if (taskQueue.Count == 0)
            {
                Console.WriteLine("There are no tasks to update.");
                return;
            }

            Console.WriteLine("Enter the task name to update:");
            taskNameToUpdate = Console.ReadLine();

            foreach (Task task in taskQueue.ToArray())
            {
                if (task.Name == taskNameToUpdate)
                {
                    Console.Write("New Task Name: ");
                    newTaskName = Console.ReadLine();

                    Console.Write("New Priority (1-5): ");
                    int newPriority;

                    while (!int.TryParse(Console.ReadLine(), out newPriority) || newPriority < 1 || newPriority > 5)
                    {
                        Console.WriteLine("Invalid priority. Please enter a number between 1 and 5.");
                    }

                    Console.Write("New Deadline (YYYY-MM-DD HH:MM): ");

                    while (!DateTime.TryParse(Console.ReadLine(), out newDeadline))
                    {
                        Console.WriteLine("Invalid date format. Please enter in the format YYYY-MM-DD HH:MM.");
                    }
                    while (newDeadline < DateTime.Now)
                    {
                        Console.WriteLine("Warning: The entered deadline is in the past.");
                        Console.WriteLine("Please enter a valid date.");

                        newDeadline = DateTime.Parse(Console.ReadLine());

                        // Optionally, you can provide additional instructions or ask the user to re-enter the deadline.
                        if (newDeadline > DateTime.Now)
                            break;
                    }

                    // Remove the old task and add the updated task
                    taskQueue.Enqueue(new Task(newTaskName, newPriority, newDeadline));
                    taskQueue.Dequeue(); // Remove the old task

                    Console.WriteLine("Task updated successfully.");
                    return;
                }
            }

            Console.WriteLine($"Task with name '{taskNameToUpdate}' not found.");
        }

        public void DeleteTask()
        {
            if (taskQueue.Count == 0)
            {
                Console.WriteLine("There are no tasks to delete.");
                return;
            }

            Console.WriteLine("Enter the task name to delete:");
            string taskNameToDelete = Console.ReadLine();

            // Use a temporary list to store tasks to be kept
            List<Task> tasksToKeep = new List<Task>();

            foreach (Task task in taskQueue.ToArray())
            {
                if (task.Name != taskNameToDelete)
                {
                    tasksToKeep.Add(task);
                }
            }

            if (tasksToKeep.Count < taskQueue.Count)
            {
                Console.WriteLine($"Task with name '{taskNameToDelete}' deleted successfully.");

                // Clear the existing queue and enqueue the tasks to be kept
                taskQueue = new PriorityQueue<Task>();
                foreach (Task task in tasksToKeep)
                {
                    taskQueue.Enqueue(task);
                }
            }
            else
            {
                Console.WriteLine($"Task with name '{taskNameToDelete}' not found.");
            }
        }
    }

    // Custom Priority Queue implementation using arrays
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private int defaultCapacity = 1;
        private T[] queue;
        public int Count { get; private set; }
        // default const.
        public PriorityQueue()
        {
            queue = new T[defaultCapacity];
            Count = 0;
        }
        // byda5l el values fe el queue
        public void Enqueue(T item)
        {
            if (Count == queue.Length)
            {
                ResizeArray();
            }

            int i;
            for (i = Count - 1; i >= 0 && item.CompareTo(queue[i]) > 0; i--)
            {
                queue[i + 1] = queue[i];
            }

            queue[i + 1] = item;
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T item = queue[--Count];
            queue[Count] = default(T); // Optional: Set the dequeued item to its default value
            return item;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
            Array.Copy(queue, array, Count);
            return array;
        }

        public IEnumerable<T> GetTasks()
        {
            return queue.Take(Count);
        }

        private void ResizeArray()
        {
            int newCapacity = queue.Length *2;
            T[] newArray = new T[newCapacity];
            Array.Copy(queue, newArray, Count);
            queue = newArray;
        }
    }

    // Main program class
    class Program
    {
       // [STAThread]
        static void Main()
        {
         //   Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new menuForm());
            // Create an instance of TaskScheduler
            TaskScheduler taskScheduler = new TaskScheduler();

            Console.WriteLine("Task Scheduler Program");
            Console.WriteLine("----------------------");

            while (true)
            {
            ContinueSwitch:
                Console.WriteLine("1-Add Task");
                Console.WriteLine("2-Display");
                Console.WriteLine("3-Update");
                Console.WriteLine("4-Delete");
                Console.WriteLine("5-Execute");
                Console.WriteLine("6-Exit");
                Console.Write("Enter number: ");

                int menu;
                if (!int.TryParse(Console.ReadLine(), out menu))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                Console.WriteLine("--------------------------------------------------------------------------------");

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Enter tasks.");
                        Console.WriteLine("------------");

                        while (true)
                        {
                            Console.Write("Task Name: ");
                            string taskName = Console.ReadLine();

                            if (taskName.ToLower() == "finish")
                                break;
                            if (taskName.ToLower() == "x")
                                goto ContinueSwitch;

                            Console.Write("Priority (1-5): ");
                            int priority;

                            while (!int.TryParse(Console.ReadLine(), out priority) || priority < 1 || priority > 5)
                            {
                                Console.WriteLine("Invalid priority. Please enter a number between 1 and 5.");
                            }

                            Console.Write("Deadline (YYYY-MM-DD HH:MM): ");
                            DateTime deadline;

                            while (!DateTime.TryParse(Console.ReadLine(), out deadline))
                            {
                                Console.WriteLine("Invalid date format. Please enter in the format YYYY-MM-DD HH:MM.");
                            }

                            while (deadline < DateTime.Now)
                            {
                                Console.WriteLine("Warning: The entered deadline is in the past.");
                                Console.WriteLine("Please enter a valid date.");

                                deadline = DateTime.Parse(Console.ReadLine());

                                // Optionally, you can provide additional instructions or ask the user to re-enter the deadline.
                                if (deadline > DateTime.Now)
                                    break;
                            }

                            // Add the entered task to the scheduler
                            taskScheduler.AddTask(taskName, priority, deadline);
                            Console.WriteLine("--------------------------------------------------------------------------------");
                            Console.WriteLine("------------------------");
                            Console.WriteLine("Enter 'finish' to execute.|");
                            Console.WriteLine("------------------------");
                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Enter 'x' to return to the menu.|");
                            Console.WriteLine("-------------------------------");
                        }
                        break;

                    case 2:
                        taskScheduler.DisplayTasks();
                        break;

                    case 3:
                        taskScheduler.UpdateTask();
                        break;

                    case 4: 
                         taskScheduler.DeleteTask();
                        break;

                    case 5:
                        taskScheduler.ExecuteTasks();
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }
        }
    }
}
