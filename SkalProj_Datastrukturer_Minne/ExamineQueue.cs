using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    /// <summary>
    /// Examines the datastructure Queue
    /// </summary>
    /*
     * Loop this method untill the user inputs something to exit to main menue.
     * Create a switch with cases to enqueue items or dequeue items
     * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
    */

    public static class ExamineQueue
    {
        static void QueueMenu()
        {
            Console.WriteLine("This is the queue menu");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Examine");
            Console.WriteLine("2. Peek at");
            Console.WriteLine("3. Enqueue");
            Console.WriteLine("4. Dequeue");
            Console.WriteLine("5. Check if contains");
            Console.WriteLine("M. Go to main menu");
            Console.WriteLine("0. Exit application");
        }

        public static void App()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("how");
            queue.Enqueue("are");
            queue.Enqueue("you");
            queue.Enqueue("today?");

            while (true)
            {
                QueueMenu();
                char userInput = Helper.GetCharInput();
                switch (userInput)
                {
                    case '1':
                        Helper.ExecuteAction(() =>
                        {
                            queue.ToList().ForEach(x => Console.WriteLine(x));
                        });
                        break;
                    case '2':
                        Helper.ExecuteAction(() =>
                        {
                            Console.WriteLine(queue.Peek());
                        });
                        break;
                    case '3':
                        Console.WriteLine("Enter a string");
                        Helper.ExecuteAction(() =>
                        {
                            queue.Enqueue(Console.ReadLine()!);
                            Console.WriteLine("The queue now consists of:");
                            queue.ToList().ForEach(x => Console.WriteLine(x));
                        });
                        break;
                    case '4':
                        Helper.ExecuteAction(() =>
                        {
                            queue.Dequeue();
                            Console.WriteLine("The queue now consists of:");
                            queue.ToList().ForEach(x => Console.WriteLine(x));
                        });
                        break;
                    case '5':
                        Console.WriteLine("Enter a string");
                        Helper.ExecuteAction(() =>
                        {
                           bool queueContains = queue.Contains(Console.ReadLine());
                           Console.WriteLine(queueContains);
                        });
                        break;
                    case 'M' or 'm':
                        Console.Clear();
                        Program.Main();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter some valid input");
                        break;
                }
            }
        }

    }
}
