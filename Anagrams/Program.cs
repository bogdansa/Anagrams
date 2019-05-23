using System;
using System.Linq;

namespace Anagrams
{
    class Program
    {
        private const string defaultFileName = @"..\..\Anagrams.txt";

        static void Main(string[] args)
        {
            string[] inputWords = System.IO.File.ReadAllLines(defaultFileName);

            var anagramSets = inputWords.GroupBy(word => String.Concat(word.OrderBy(character => character)))
                .OrderByDescending(set => set.First().Count())
                .OrderByDescending(set => set.Count());

            foreach (var set in anagramSets)
            {
                Console.WriteLine(string.Join(" ", set.OrderBy(word => word)));
            }
            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
