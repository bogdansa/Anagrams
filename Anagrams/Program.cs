using System;
using System.Linq;

namespace Anagrams
{
    public class Program
    {
        private const string DefaultFileName = @"..\..\Anagrams.txt";

        private static void Main()
        {
            string[] inputWords = System.IO.File.ReadAllLines(DefaultFileName);

            var anagramSets = inputWords.GroupBy(word => string.Concat(word.OrderBy(character => character)))
                .OrderByDescending(set => set.Count())
                .ThenByDescending(set => set.First().Length);

            foreach (var set in anagramSets)
            {
                Console.WriteLine(string.Join(" ", set.OrderBy(word => word)));
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
