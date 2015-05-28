using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            using (var reader = new StreamReader("../../LineNumbers.cs"))
            {
                using (var writer = new StreamWriter("../../MyCode.txt"))
                {
                    int counter = 1;
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine("{0,4}. {1}",counter,line);
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
