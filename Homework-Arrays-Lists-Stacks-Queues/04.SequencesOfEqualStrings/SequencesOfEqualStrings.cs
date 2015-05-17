using System;
using System.Collections.Generic;

class SequencesOfEqualStrings
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] arrString = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
       List<string> listString = new List<string>();
        for (int i = 0, j = 1; i < arrString.Length; i++,j++)
        {
            listString.Add(arrString[i]);
            if ((j < arrString.Length) && (arrString[i].Equals(arrString[j])))
            {
                continue;
            }
            else
            {
                Console.WriteLine(string.Join(" ",listString));
                listString.Clear();
            }
        }
    }
}

