using System;

class StringLength
{
    static void Main()
    {
        string str = Console.ReadLine();

        string replace = str.Length > 20 ? str.Substring(0, 20) : str.PadRight(20, '*');

        Console.WriteLine("Text after treatment : {0} ", replace);

    }
}
