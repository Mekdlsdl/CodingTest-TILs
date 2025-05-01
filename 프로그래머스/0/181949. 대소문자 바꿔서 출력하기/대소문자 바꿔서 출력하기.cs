using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        foreach (Char c in s)
        {
            if (Char.IsLower(c))
            {
                Console.Write(Char.ToUpper(c));
            }
            else
            {
                Console.Write(Char.ToLower(c));
            }
        }

    }
}