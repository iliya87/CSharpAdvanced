using System;
using System.Text;

class TextFilter
{
    static void Main()
    {
        
        string[] banned = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
     
        string text = Console.ReadLine();

        string[] replaceChar = new string[banned.Length];
        StringBuilder sb = new StringBuilder(text);

        for (int i = 0; i < banned.Length; i++)
        {
            replaceChar[i] = new String('*', banned[i].Length);
            sb.Replace(banned[i], replaceChar[i]);

        }
        Console.WriteLine(sb);

     }
}

