using System;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
            string input = Console.ReadLine();
            string pattern = @"<a\s+href=([^>]+)>([^<]+)</a>";
            new Regex(pattern);
            string replacement = "[URL href=$1]$2[/URL]";
            string result = Regex.Replace(input, pattern, replacement);
            Console.WriteLine(result);
    }
}


 
  
 


