// FINAL C# PROJECT - TASK MANAGER
// The 'using' directive allows all the names in a namespace to be used without the namespace-name as an explicit qualifier
using System;
using System.Collections.Generic;

namespace MyApp
{
    class Program
    {
        // MAIN METHOD
        static void Main(string[] args)
        {
            string response;
            int parsedResponse;
            var menuList = new List<string>(){ "1. Add a task", "2. Remove a task", "3. Mark a task complete", "4. List the tasks", "", "What would you like to do?" };                                     
            
            // 'taskList' and 'completeList' run with parallel indices to keep track if a task is complete
            var taskList = new List<string>();
            var completeList = new List<string>();

            // BIG FOR LOOP (arbitrarily large loop to keep the program running)
            for (int i = 0; i < 1000000; i++)
            {              
                // DISPLAY THE MENU LOOP
                void displayMenu()
                {
                Console.Clear();
                
                for (int j = 0; j < menuList.Count; j++)
                {
                Console.WriteLine(menuList[j]);
                }
                
                // WAIT FOR SELECTION 
                response = Console.ReadLine();
                
                // 'if' STATEMENT TREE TO DIRECT TO PROPER METHODS
                if (response == "1")
                { addTask(); }
                
                else if (response == "2")
                { removeTask(); }
                    
                else if (response == "3")
                { completeTask(); }
            
                else if (response == "4")
                { listTask(); }
                }
           
                displayMenu();

                // ////////////  METHODS  ////////////
                   
                // 1. ADD A TASK METHOD
                void addTask() 
                {   
                    Console.Clear();
                    Console.WriteLine("Please add a task:");
                    response = Console.ReadLine();
                    // add item to 'taskList' and 'completeList'
                    taskList.Add(response);
                    completeList.Add("");
                }
                       
                // 2. REMOVE A TASK METHOD
                void removeTask()
                {
                    // if there is nothing in the list
                    if (taskList.Count == 0)
                    {
                    Console.WriteLine("-- There are currently NO tasks in your list --");   
                    Console.WriteLine("");
                    Console.WriteLine("Please hit 'Enter' to return to Main Menu");
                    }

                    Console.Clear();
                    Console.WriteLine("Here is your Current Task List:");
                    Console.WriteLine("");

                    for (int j = 0; j < taskList.Count; j++)
                    {
                    Console.WriteLine((j+1) + ". " + taskList[j] + " " + completeList[j]);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Please enter the number of the task you would like removed");

                    //  prevent 'index' < 0 program crash
                    if (taskList.Count != 0)
                    {
                    response = Console.ReadLine();
                    parsedResponse = Int32.Parse(response);
                    
                    taskList.Remove(taskList[(parsedResponse-1)]);
                    completeList.Remove(completeList[(parsedResponse-1)]);
                    }
                }
                    
                // 3. MARK A TASK COMPLETE METHOD
                void completeTask()
                {
                    Console.Clear();
                    Console.WriteLine("Here is your Current Task List:");
                    Console.WriteLine("");

                    // if there is nothing in the list
                    if (taskList.Count == 0)
                    {
                    Console.WriteLine("-- There are currently NO tasks in your list --");
                    }

                    for (int j = 0; j < taskList.Count; j++)
                    {
                    Console.WriteLine((j+1) + ". " + taskList[j] + " " + completeList[j]);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Please enter the number of the task that you have completed");

                    response = Console.ReadLine();
                    parsedResponse = Int32.Parse(response);
                    completeList[(parsedResponse-1)] = ("(COMPLETE)");
                }

                // 4. LIST THE TASKS METHOD
                void listTask()
                {
                    Console.Clear();
                    Console.WriteLine("Here is your Current Task List:");
                    Console.WriteLine("");
                    
                    // if there is nothing in the list
                    if (taskList.Count == 0)
                    {
                    Console.WriteLine("-- There are currently NO tasks in your list --");
                    }

                    for (int j = 0; j < taskList.Count; j++)
                    {
                    Console.WriteLine((j+1) + ". " + taskList[j] + " " + completeList[j]);
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Please hit 'Enter' to return to Main Menu");
                    response = Console.ReadLine();
                }
            }
        }
    }   
}
