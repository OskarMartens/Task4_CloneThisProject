using System;

public static class Helper
{
    public static char GetCharInput()
    {
        char input = ' ';
        try
        {
            input = Console.ReadLine()![0];
        }
        catch (IndexOutOfRangeException)
        {
            Console.Clear();
            Console.WriteLine("Please enter some input!");
        }
        return input;
    }

    public static string GetStringInput()
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

    public static void ExecuteAction(Action action)
    {
        try
        {
            action();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
