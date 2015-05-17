using System;
using System.Linq;

class LettersChangeNumbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
        decimal value = 0;
        foreach (var str in input)
        {
            decimal number = Convert.ToDecimal(str.Substring(1,str.Length - 2));
            if (Char.IsLower(str.First()))
            {
                number *= (decimal) str.First() - 96;

            }
            else
            {
                number /= (decimal) str.First() - 64;

            }
            if (Char.IsLower(str.Last()))
            {
                number += (decimal) str.Last() - 94;
            }
            else
            {
                number -= (decimal) str.Last() - 64;
            }
            value += number;

        }
        Console.WriteLine("{0:F2}",value);

    }
}

