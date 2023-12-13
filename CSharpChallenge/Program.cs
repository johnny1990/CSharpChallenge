// See https://aka.ms/new-console-template for more information

using CSharpChallenge.Models;
using CSharpChallenge.Operations;

List<Tasks> taskList = new List<Tasks>();

List<Categories> categoryList = new List<Categories>();
categoryList.Add(new Categories { Id = 1, Name = "Important" });
categoryList.Add(new Categories { Id = 2, Name = "LessImportant" });

while (true)
{
    TaskOperations.DisplayMenu();

    string response = Console.ReadLine().ToString();

    if (response == "Display")
    {
        TaskOperations.DisplayTasks(taskList);
    }

    if (response == "Add")
    {
        TaskOperations.AddTask(taskList);
    }

    if (response == "Edit")
    {
        TaskOperations.EditTask(taskList);
    }

    if (response == "Delete")
    {
        TaskOperations.DeleteTask(taskList);
    }

    if (response == "Filter")
    {
        TaskOperations.FilterTasks(taskList);
    }

    else
    {
        Console.WriteLine("Go to main menu!");
    }

    Console.ReadLine();
}