using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace todolistapplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declared variables
            bool keepGoingProgram;
            int menuOption;
            string todoTitle;
            string todoDescription;
            string todoTitleCompleted;
            int i;


            //Initialized variables
            keepGoingProgram = true;
            menuOption= 0;
            todoTitle= string.Empty;
            todoDescription= string.Empty;
            todoTitleCompleted = string.Empty;
            i = 0;


            List<TodoItems> toDoList = new List<TodoItems>();
            Console.WriteLine("\n---ToDo List Application---\n");

            do
            {
                Console.WriteLine("Enter 1 to Add New ToDo\nEnter 2 to View Current ToDo\nEnter 3 to Mark ToDo Complete\nEnter 4 to Exit The Program\n");
                if (!int.TryParse(Console.ReadLine(), out menuOption))
                {
                    Console.WriteLine("Invalid input, please enter number.\n");
                }
                
                if (menuOption == 4)
                {
                    keepGoingProgram = false;
                }

                if (menuOption == 1)
                {
                    Console.WriteLine("Enter ToDo Title: ");
                    todoTitle = Console.ReadLine();
                    Console.WriteLine("Enter ToDo Description: ");
                    todoDescription = Console.ReadLine();
                    Console.WriteLine("Enter ToDo Duedate (yyyy-mm-dd): ");
                    DateTime dueDate = DateTime.Parse(Console.ReadLine());

                    TodoItems newitems = new TodoItems(todoTitle, todoDescription, dueDate);
                    toDoList.Add(newitems);
                    Console.WriteLine("ToDo Added Sucessfully\n");
                }

                if (menuOption == 2)
                {
                    if (toDoList.Count == 0)
                    {
                        Console.WriteLine("No ToDo Found.\n");
                    }
                    else
                    {
                        for (i = 0; i < toDoList.Count; i++)
                        {
                           Console.WriteLine($"Title: {toDoList[i].title} | Description: {toDoList[i].description} | DueDate: {toDoList[i].dueDate}");
                        }
                    }
                    
                }

                if (menuOption == 3)
                {
                    Console.WriteLine("Enter title of the ToDo to mark as completed: ");
                    todoTitleCompleted = Console.ReadLine();

                    int index = -1;
                
                    for (i = 0; i < toDoList.Count; i++)
                    {
                        if (toDoList[i].title == todoTitleCompleted)
                        {
                            index= i;
                            break;
                        }
                    }
                    if (index != -1)
                    {
                        toDoList.RemoveAt(index);
                        Console.WriteLine("ToDo marked as completed and removed from list\n");
                    }
                    else
                    {
                        Console.WriteLine("ToDo not found.");
                    }
                }

            } while (keepGoingProgram);
            


            Console.ReadKey(); 
        }
    }
}
