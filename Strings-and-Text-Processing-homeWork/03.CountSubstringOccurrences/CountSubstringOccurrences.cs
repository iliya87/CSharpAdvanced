using System;

class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string search = Console.ReadLine();

            int numOcc = 0;
            int startIndex = 0;
            while (text.IndexOf(search, startIndex, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                numOcc++;
                startIndex = text.IndexOf(search, startIndex, StringComparison.OrdinalIgnoreCase) + 1;
            }
            Console.WriteLine(numOcc);
        }
    }

