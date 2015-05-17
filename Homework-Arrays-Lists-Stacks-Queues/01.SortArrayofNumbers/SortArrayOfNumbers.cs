using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class SortArrayOfNumbers
{
    private static void Main(string[] args)
    {
        string numbs = Console.ReadLine();
        int[] arr = numbs.Split().Select(int.Parse).ToArray();

        Array.Sort(arr);
        foreach (var numb in arr)
        {
            Console.Write(numb + " ");
        }
    }

}
