using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem_1
{
    class Program
    {
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

        //Find the sum of all the multiples of 3 or 5 below 1000.

        public static bool Multiple(int value, int divisor)
        {
            // Is the value an exact multiple of the divisor?
            var result = (value % divisor == 0) ? true : false;

            return result;
        }


        public static int Iteration()
        {
            // Run through each integer
            var upperLimit = 1000;

            var sumOfMultiples = 0;

            for (int i = 0; i < upperLimit; i++)
            {
                if (Multiple(i, 3) || Multiple(i, 5))
                {
                    sumOfMultiples += i;
                }
            }

            return sumOfMultiples;
        }


        static void Main()
        {
            var watch = new Stopwatch();

            watch.Start();

            var sum = Iteration();

            watch.Stop();

            Console.WriteLine(string.Format("The sum of all multiples of 3 and 5 below 1000 is {0}.", sum));
            Console.WriteLine(string.Format("The time taken was {0}", watch.Elapsed));
            Console.ReadLine();

        }
    }
}
