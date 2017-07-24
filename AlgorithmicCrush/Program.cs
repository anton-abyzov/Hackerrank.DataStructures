using System;
using System.Linq;

namespace AlgorithmicCrush
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(line, long.Parse);
            var n = arr[0];
            var m = arr[1];
            var array = new long[n + 1];
            while (m-- > 0)
            {
                var line1 = Console.ReadLine().Split(' ');
                var line1Arr = Array.ConvertAll(line1, long.Parse);
                var a = line1Arr[0];
                var b = line1Arr[1];
                var k = line1Arr[2];

                array[a] += k;
                if (b + 1 <= n)
                    array[b + 1] -= k;
            }
            long currentMax = 0;
            long max = 0;
            for (int i = 1; i <= n; i++)
            {
                currentMax += array[i];
                if (currentMax > max)
                    max = currentMax;
            }
            Console.WriteLine(max);
        }
    }
}