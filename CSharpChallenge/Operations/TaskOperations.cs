using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChallenge.Operations
{
    public static class TaskOperations
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("List of actions");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("For display list of all tasks type Display");
            Console.WriteLine("For add a new task type Add");
            Console.WriteLine("For edit a new task type Edit");
            Console.WriteLine("For delete a new task type Delete");
            Console.WriteLine("For filter tasks by category type Filter");
            Console.WriteLine("------------------------------------------------------------------------------");

        }

        public static void DisplayTasks(List<Models.Tasks> taskList)
        {
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("List of tasks");
            Thread.Sleep(1000);

            foreach (var item in taskList)
            {
                Console.WriteLine("Id: " + item.Id + " / " + "Name: " + item.Name + " / " + "Description: " + item.Description +
                                       " / " + "ScheduledTime: " + item.ScheduledTime + " / " + "Category: " + item.CategoryId);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }



        public static void AddTask(List<Models.Tasks> taskList)
        {
            int id = 0;
            if (taskList.Count == 0)
            {
                id++;
            }
            else
            {
                id = taskList.Count + 1;
            }

            Console.WriteLine("Id value: " + id);
            Console.WriteLine("Type name");
            string name = Console.ReadLine();
            Console.WriteLine("Type description");
            string desc = Console.ReadLine();
            DateTime schtime = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));
            Console.WriteLine("Type CategoryId");
            int categoryId = Int32.Parse(Console.ReadLine());

            taskList.Add(new Models.Tasks { Id = id, Name = name, Description = desc, ScheduledTime = schtime, CategoryId = categoryId });

            Thread.Sleep(1000);
            Console.WriteLine("Task added successfully!");
        }

        public static void EditTask(List<Models.Tasks> taskList)
        {
            Console.WriteLine("Enter Id task for edit");
            int id = Int32.Parse(Console.ReadLine());

            //display task for edit
            foreach (var item in taskList)
            {
                if (item.Id == id)
                {
                    Console.WriteLine("Id: " + item.Id + " / " + "Name: " + item.Name + " / " + "Description: " + item.Description +
                                                              " / " + "ScheduledTime: " + item.ScheduledTime + " / " + "Category: " + item.CategoryId);
                }
                else
                {
                    Console.WriteLine("Task with entered Id does not exist!");
                }
            }

            Console.WriteLine("Type name new value for update!");
            string name = Console.ReadLine();

            Console.WriteLine("Type description new value for update!");
            string desc = Console.ReadLine();

            DateTime schtime = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));

            Console.WriteLine("Type CategoryId new value for update!");
            int categoryId = Int32.Parse(Console.ReadLine());

            foreach (var item in taskList)
            {
                if (item.Id == id)
                {
                    item.Name = name;
                    item.Description = desc;
                    item.ScheduledTime = schtime;
                    item.CategoryId = categoryId;
                }
            }
            Thread.Sleep(1000);
            Console.WriteLine("Task updated successfully!");
        }

        public static void DeleteTask(List<Models.Tasks> taskList)
        {
            Console.WriteLine("Type task Id for delete");
            int id = Int32.Parse(Console.ReadLine());

            taskList.RemoveAt(id - 1);

            Thread.Sleep(1000);
            Console.WriteLine("Task deleted successfully!");
        }

        public static void FilterTasks(List<Models.Tasks> taskList)
        {
            Console.WriteLine("Type category Id for filter");
            int id = Int32.Parse(Console.ReadLine());

            foreach (var item in taskList)
            {
                if (item.CategoryId == id)
                {
                    Console.WriteLine("Id: " + item.Id + " / " + "Name: " + item.Name + " / " + "Description: " + item.Description +
                                                                                     " / " + "ScheduledTime: " + item.ScheduledTime + " / " + "Category: " + item.CategoryId);
                }
                else
                {
                    Console.WriteLine("We don't have any task matching your category!");
                }
            }
        }

    }
}
