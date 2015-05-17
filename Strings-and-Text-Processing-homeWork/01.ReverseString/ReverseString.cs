using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        string str = Console.ReadLine();
        string rev = new string(str.Reverse().ToArray());
        Console.WriteLine(rev);
    
    }
}

