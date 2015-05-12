using System;

class ReverseNumber
{
     
    static void Main(string[] args)
    {
        double input = Double.Parse(Console.ReadLine());

        Console.WriteLine(ReverseDouble(input));
    }

    static double ReverseDouble(double number)
    {
        char[] arr = number.ToString().ToCharArray();
        Array.Reverse(arr);
        return Convert.ToDouble(new string(arr));
    }
    
}

