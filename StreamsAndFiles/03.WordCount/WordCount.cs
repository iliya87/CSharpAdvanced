using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main()
        {
            using (var wordReader = new StreamReader("../../word.txt"))
            {
                using (var textReader = new StreamReader("../../text.txt"))
                {
                    using (var writer = new StreamWriter("../../result.txt"))
                    {
                        var words = new List<string>();
                        var word = wordReader.ReadLine();
                        while (word != null)
                        {
                            words.Add(word);
                            word = wordReader.ReadLine();
                        }
                        var text = textReader.ReadToEnd().ToLower();
                        var result = new SortedDictionary<int,string>();
                        words.ForEach(x =>
                        {
                            var regex = @"\b" + x.ToLower() + @"\b";
                            var match = Regex.Matches(text, regex);result.Add(match.Count,x);
                        });

                        foreach (var foundWords in result.Reverse())
                        {
                            writer.WriteLine("{0} - {1}",foundWords,foundWords.Key);
                            Console.WriteLine("{0} - {1}", foundWords, foundWords.Key);
                        }

                    }
                }
            }
        }
    }
}
