using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> Tasks = new List<Task>();
             
            
            ManagerMainMenu();
            string userInput = Console.ReadLine();
            
            int input = int.Parse(userInput);
            
            
            switch (input)
            {

                case 1:
                    foreach (var i in Tasks)
                    {
                        Console.WriteLine(i);
                    }                   
                    break;

                case 2:
                    Console.WriteLine("Add Task.");
                    Console.WriteLine("Team Member Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Task Description: ");
                    string dis =Console.ReadLine();
                    Console.WriteLine("Due Date: ");
                    string due = Console.ReadLine();
                    DateTime date = Convert.ToDateTime(due);
                     
                    Task newTask = new Task(n,dis,date);
                    Tasks.Add(newTask);

                    Console.WriteLine("Your Task Has Been Added.");
                    break;

                case 3:
                    Console.WriteLine("Which task would you like to delete.");

                    break;

                case 4:
                    Console.WriteLine("Which task would you like to mark as complete.");

                    break;

                case 5:

                    break;

            }            

            Console.ReadLine();
        }


        public static bool Continue()
        {
            Console.WriteLine("Again? {Y/N}");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else Console.WriteLine("Please Try Again.");

            return Continue();
        }

        public static void ManagerMainMenu()
        {
            Console.WriteLine("Welcome to the Task Manager.");

            
            Console.WriteLine("1. List Tasks"); 
            Console.WriteLine("2. Add Task"); 
            Console.WriteLine("3. Delete Task"); 
            Console.WriteLine("4. Mark Task As Complete");
            Console.WriteLine("5. Quit.");

            
        }
    }
}
