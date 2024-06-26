﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    public static class CheckParentheses
    {
        static void ParenthesesMenu()
        {
            Console.WriteLine("This is the CheckParentheses menu.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Check the string \"[({})]\"");
            Console.WriteLine("2. Check the string \"{}()((\"");
            Console.WriteLine("3. Enter your own string");
            Console.WriteLine("M. Go to main menu");
            Console.WriteLine("0. Exit application");
        }

        public static void App()
        {
            string falseParentheses = "{}()((";
            string trueParentheses = "[({})]";
            string toCheck = falseParentheses;

            while (true)
            {
                ParenthesesMenu();
                char userInput = Helper.GetCharInput();
                switch (userInput)
                {
                    case '1':
                        Console.WriteLine(ValidateParentheses(trueParentheses));
                        break;

                    case '2':
                        Console.WriteLine(ValidateParentheses(falseParentheses));
                        break;

                    case '3':
                        Helper.ExecuteAction(() =>
                        {
                            string stringInput = Helper.GetStringInput();
                            Console.WriteLine(ValidateParentheses(stringInput));
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
                        Console.WriteLine("Please enter some valid input (1, 2, 3, 4, M or 0)");
                        break;
                }
            }
        }

        static bool ValidateParentheses(string input)
        {
            Stack<char> charStack = new Stack<char>();
            foreach (char c in input)
            {
                switch (c)
                {
                    case '(':
                    case '{':
                    case '[':
                        charStack.Push(c);
                        break;

                    case ')':
                        if (charStack.Count == 0 || charStack.Peek() != '(')
                            return false;
                        charStack.Pop();
                        break;

                    case ']':
                        if (charStack.Count == 0 || charStack.Peek() != '[')
                            return false;
                        charStack.Pop();
                        break;

                    case '}':
                        if (charStack.Count == 0 || charStack.Peek() != '{')
                            return false;
                        charStack.Pop();
                        break;
                }
            }
            return charStack.Count == 0;
        }
    }
}

