using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{

    /// <summary>
    /// Examines the datastructure List
    /// </summary>
    /// 
    /*

* In both cases, look at the count and capacity of the list
* As a default case, tell them to use only + or -
*/ 
    public static class ExamineList
    {
        public static void App()
        {
            List<string> theList = new List<string>();

            while (true)
            {
                ExamineListMenu();

                string input = Console.ReadLine();
                char nav = ' ';
                try
                {
                    nav = input[0];
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter some input!");
                    continue;
                }
                string value = input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        PrintListInfo(theList);
                        break;
                    case '-':
                        int removedCount = theList.RemoveAll(x => x.Equals(value));
                        if (removedCount == 0)
                        {
                            Console.WriteLine("The string you tried to remove did not exist in the list.");
                        }
                        PrintListInfo(theList);
                        break;
                    case 'M' or 'm':
                        Console.Clear();
                        Program.Main();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter some valid input, use only \'+\' or \'-\' to begin a string");
                        break;
                }
            }
        }

        static void ExamineListMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Add something to the list by using the \'+\' or \'-\' sign followed by the string you want to add or remove." +
                "\nPress \'M\' to go to the main menu." +
                "\nPress \'0\' to exit the application.");
        }

        static void PrintListInfo(List<string> list)
        {
            Console.WriteLine();
            Console.WriteLine($"The number of strings in the list is: {list.Count}");
            Console.WriteLine("Here are the strings:");
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}