using System;
using System.Linq;

class LargerThanNeighbours
{
    static int[] arr;

    static bool CheckIfGreater(int numbs)
    {
        bool isGreater;
        if (numbs == 0)
        {
            isGreater = arr[numbs] > arr[numbs + 1];
        }
        else if (numbs == arr.Length - 1)
        {
            isGreater = arr[numbs] > arr[numbs - 1];
        }
        else
        {
            isGreater = arr[numbs] > arr[numbs - 1] && arr[numbs] > arr[numbs + 1];
        }
        return isGreater;
    }
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        if (input != null) arr = input.Split().Select(int.Parse).ToArray();

        for (int index = 0; index < arr.Length; index++)
        {
            Console.WriteLine(CheckIfGreater(index));
        }
    }

    public static int number { get; set; }
}

