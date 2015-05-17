using System;
using System.Linq;

class SelectionSort
{ 
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split().Select(int.Parse).ToArray();

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int minValue = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minValue])
                {
                    minValue = j;
                }
            }
            int temp = numbers[i];
            numbers[i] = numbers[minValue];
            numbers[minValue] = temp;
        }
        foreach (var n in numbers)
        {
            Console.Write(n + " ");
        }
    }
}

