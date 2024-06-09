using System.Reflection.Metadata.Ecma335;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                MainMenuText();
                char input = GetUserInput(); //Creates the character input to be used with the switch-case below.

                switch (input)
                {
                    case '1':
                        ExamineList();
                        //input = false;
                        break;
                    case '2':
                        ExamineQueue();
                        //input = false;
                        break;
                    case '3':
                        ExamineStack();
                        //input = false;
                        break;
                    case '4':
                        CheckParanthesis();
                        //input = false;
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        static void MainMenuText()
        {
            Console.WriteLine(
                "Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                                + "\n1. Examine a List"
                                + "\n2. Examine a Queue"
                                + "\n3. Examine a Stack"
                                + "\n4. CheckParenthesis"
                                + "\n0. Exit the application");
        }

        static char GetUserInput()
        {
            char input = ' ';
            try
            {
                input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                Console.Clear();
                Console.WriteLine("Please enter some input!");
            }
            return input;
        }

        static string UserStringInput()
        {
            string input = string.Empty;
            try
            {
                input = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Enter a non empty value");                
            }
            return input;
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        /// 
        /*

 * In both cases, look at the count and capacity of the list
 * As a default case, tell them to use only + or -
*/
        static void ExamineList()
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
                        Main();
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


        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        static void ExamineQueue()
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
                char userInput = GetUserInput();
                switch(userInput)
                {
                    case '1':
                        Console.Clear();
                        queue.ToList().ForEach(x => Console.WriteLine(x));
                        break;
                    case '2':
                        try
                        {
                            Console.Clear();
                            Console.WriteLine(queue.Peek());
                        } 
                        catch(Exception e)
                        {
                            Console.WriteLine(e);
                            continue;
                        }
                        break;
                    case '3':
                        Console.WriteLine("Enter a string");
                        queue.Enqueue(Console.ReadLine());
                        Console.WriteLine("The queue now consist of:");
                        queue.ToList().ForEach(x => Console.WriteLine(x));
                        break;
                    case '4':
                        try
                        {
                            queue.Dequeue();
                            Console.WriteLine("The queue now consist of:");
                            queue.ToList().ForEach(x => Console.WriteLine(x));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        break;
                    case '5':
                        Console.WriteLine("Enter a string");
                        bool queueContains = queue.Contains(Console.ReadLine());
                        Console.WriteLine(queueContains);
                        break;
                    case 'M' or 'm':
                        Main();
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

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        static void ExamineStack()
        {

        }
        static void StackMenu()
        {
            Console.Clear();
            Console.WriteLine("This is the stack menu.")
            Console.WriteLine("What would you like to do?");


        }

            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
        static void CheckParanthesis()
        {
            string falseParantheses = "{}()((";
            string trueParantheses = "[({})]";
            string toCheck = falseParantheses;            
        }
    }
}

