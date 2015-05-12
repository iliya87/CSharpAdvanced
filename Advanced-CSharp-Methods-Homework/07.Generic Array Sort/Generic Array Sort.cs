using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

class GenericArraySort
{
    
        static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        string[] strings = { "Filip", "Gosho", "Ivan", "Siyana", "Ivana" };
        DateTime[] dates = { new DateTime(2001, 9, 11), new DateTime(1983, 4, 15), DateTime.Today };

        SortArray(numbers);
        SortArray(strings);
        SortArray(dates);
    }

    private static void SortArray<T>(IList<T> array) where T: IComparable<T>
    {
        int reversesCounter;
        do
        {
            reversesCounter = 0;
            for (int i = 0; i < array.Count - 1 ; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    reversesCounter++;
                }
            }
        } while (reversesCounter != 0);

        foreach (T item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    
}

