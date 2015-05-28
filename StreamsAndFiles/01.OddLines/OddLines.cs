using System;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            using (var reader = new StreamReader("../../OddLines.cs"))
            {
                int rowCounter = 0;
                var line = reader.ReadLine();
                while (line != null)
                {
                    if (rowCounter % 2 != 0)
                    {
                        Console.WriteLine("{0}.{1}", rowCounter, line);
                    }

                    rowCounter++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}