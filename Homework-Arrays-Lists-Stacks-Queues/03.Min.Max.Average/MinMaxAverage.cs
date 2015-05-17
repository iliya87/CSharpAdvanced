using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxAverage
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        double[] numbers = input.Split().Select(double.Parse).ToArray();
        List<double> roundNumb = new List<double>();
        List<double> zeroFract = new List<double>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 1 != 0)
            {
                zeroFract.Add(numbers[i]);
            }
            else
            {
                roundNumb.Add(numbers[i]);
            }
        }
        Console.WriteLine("Numbers with non-zero fraction :");
        Console.Write("[");
        foreach (var num in zeroFract)
        {
            
            Console.Write("{0},",num);
            
        }
        Console.Write("]\n");
        Console.Write(" min: {0}\n max: {1}\n sum: {2}\n avg: {3:f2}\n"
            , zeroFract.Min(), zeroFract.Max(), zeroFract.Sum(), zeroFract.Average());

        Console.WriteLine("Round numbers :");
        Console.Write("[");
        foreach (var num in roundNumb)
        {

            Console.Write("{0},", num);

        }
        Console.Write("]\n");
        Console.Write(" min: {0}\n max: {1}\n sum: {2}\n avg: {3:f2}\n"
            , roundNumb.Min(), roundNumb.Max(), roundNumb.Sum(), roundNumb.Average());


    }
}

