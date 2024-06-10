using System;
using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    /// <summary>
    /// Examines the datastructure Stack
    /// </summary>
    /*
     * Loop this method until the user inputs something to exit to main menue.
     * Create a switch with cases to push or pop items
     * Make sure to look at the stack after pushing and and poping to see how it behaves
    */
    public static class ExamineStack
    {
        static void StackMenu()
        {
            Console.WriteLine("This is the stack menu.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Examine the stack.");
            Console.WriteLine("2. Add to the stack.");
            Console.WriteLine("3. Look at the top of the stack.");
            Console.WriteLine("4. Remove the item at the top of the stack.");
            Console.WriteLine("M. Go to main menu.");
            Console.WriteLine("0. Exit the application.");
        }

        public static void App()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("This");
            stack.Push("Is");
            stack.Push("A");
            stack.Push("Sentence");

            while (true)
            {
                StackMenu();
                char userInput = Helper.GetCharInput();
                switch (userInput)
                {
                    case '1':
                        Helper.ExecuteAction(() =>
                        {
                            currentStack.ForEach(s => Console.WriteLine(s));
                        });
                        break;

                    case '2':
                        Helper.ExecuteAction(() =>
                        {
                            Console.WriteLine("Enter a string");
                            stack.Push(Console.ReadLine());
                            Console.WriteLine("The stack now consists of:");
                            stack.ToList().ForEach(s => Console.WriteLine(s));
                        });
                        break;

                    case '3':
                        Helper.ExecuteAction(() =>
                        {
                            Console.WriteLine("At the top of the stack:");
                            Console.WriteLine(stack.Peek());
                        });
                        break;

                    case '4':
                        Helper.ExecuteAction(() =>
                        {
                            stack.Pop();
                            Console.WriteLine("This is the stack now:");
                            stack.ToList().ForEach(s => Console.WriteLine(s));
                        });
                        break;

                    case 'M' or 'm':
                        Console.Clear();
                        Program.Main();
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}