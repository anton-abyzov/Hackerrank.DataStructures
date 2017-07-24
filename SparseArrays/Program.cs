using System;
using System.Collections.Generic;
using System.Linq;

namespace SparseArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var strings = new List<string>();
            var queries = new List<string>();
            while (n-- > 0)
            {
                strings.Add(Console.ReadLine());
            }
            var q = Convert.ToInt32(Console.ReadLine());
            while (q-- > 0)
            {
                queries.Add(Console.ReadLine());
            }

            foreach (var query in queries)
            {
                Console.WriteLine(strings.Count(x => x == query));
            }
        }
    }
}