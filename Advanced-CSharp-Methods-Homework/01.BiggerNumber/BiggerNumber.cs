using System;

class BiggerNumber
{
    static void Main()
    {
        int firstNumb = int.Parse(Console.ReadLine());
        int secondNumb = int.Parse(Console.ReadLine());
        Console.WriteLine("The Bigger Number is : {0} ",Bignumb(firstNumb,secondNumb));
    }

    static int Bignumb (int firstNumb, int secondNumb)
    {
        int max = Math.Max(firstNumb, secondNumb);
        return max;
    }
}

