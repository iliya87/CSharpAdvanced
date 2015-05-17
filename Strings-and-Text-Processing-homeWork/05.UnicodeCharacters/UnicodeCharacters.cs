using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class UnicodeCharacters
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
 
        foreach (var some in input)
        {
            string unicode = "\\u" + ((int)some).ToString("X").PadLeft(4, '0');
            Console.Write(unicode+" ");
        }
    }
}

