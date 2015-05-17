using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string pattern = @"\b([A-Za-z0-9]+?)[\w\-\.]*?[A-Za-z0-9]+?@[A-Za-z0-9]+?([\w\-\.]+)\2*?\.[\w]{2,}\b";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}

