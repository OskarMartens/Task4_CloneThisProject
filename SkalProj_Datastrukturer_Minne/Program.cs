namespace SkalProj_Datastrukturer_Minne
{
    public static class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        public static void Main()
        {

            while (true)
            {
                MainMenuText();
                char input = Helper.GetCharInput(); //Creates the character input to be used with the switch-case below.

                switch (input)
                {
                    case '1':
                        ExamineList.App();
                        break;
                    case '2':
                        ExamineQueue.App();
                        break;
                    case '3':
                        ExamineStack.App();
                        break;
                    case '4':
                        CheckParentheses.App();
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
    }
}
