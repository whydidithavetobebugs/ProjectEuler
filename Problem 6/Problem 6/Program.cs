using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = new List<int>();

            for (int i = 1; i < 101; i++)
            {
                integers.Add(i);
            }

            var sumThenSquare = integers.Sum() * integers.Sum();

            for (int j = 0; j < integers.Count; j++)
            {
                integers[j] = integers[j] * integers[j];
            }

            var squareThenSum = integers.Sum();

            var result = 0;

            if (squareThenSum > sumThenSquare)
            {
                result = squareThenSum - sumThenSquare;
            }
            else
            {
                result = sumThenSquare - squareThenSum;
            }

            Console.WriteLine(string.Format("The difference between the sum of the squares of the first 100 numbers and the square of the sum is {0}", result));
            Console.ReadLine();
        }
    }
}
