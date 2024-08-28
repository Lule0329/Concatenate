using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concancate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Concatenate
            string[] testPart1 = { "foo", "bar", "baz" };
            string[] testPart2 = { "apa", "bpa", "cpa" };
            Console.WriteLine("Demonstration av Concatenate:");
            string[] concatResult = Concatenate(testPart1, testPart2);
            Console.WriteLine("Sammansatt array: " + string.Join(",", concatResult));
        }

        public static string[] Concatenate(string[] part1, string[] part2)
        {
            int i = 0;
            int index = part1.Length + part2.Length;
            string[] sum = new string[index];

            foreach (string part in part1)
            {
                sum[i] = part;
                i++;
            }

            foreach (string part in part2)
            {
                sum[i] = part;
                i++;
            }

            return sum;
        }
    }
}
