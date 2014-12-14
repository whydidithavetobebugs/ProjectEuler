using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

        //If 'value' is divisible by 20, it is also divisible by 10, 5, 4, 2 and 1.
        //  19
        //If 'value' is divisible by 18, it is also divisible 9, 6 and 3.
        //  17
        //If 'value' is divisible by 16, it is also divisible by 8.
        //If 'value' is divisible by 5 AND 3 (as shown above), it is also divisible by 15.
        //If 'value' is divisible by 14, it is also divisible by 7.
        //  13
        //If 'value' is divisible by 3 AND 4 (as shown above), it is also divisible by 12.
        //  11
        //20, 19, 18, 17, 16, 14, 13, 11 are only factors we need

        public static bool IsDivisibleByAllFactors(int value)
        {
            var factors = new List<int> { 20, 19, 18, 17, 16, 14, 13, 11 };

            foreach (var factor in factors)
            {
                if (value % factor != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int Iteration()
        {
            var value = 2520;

            while (!IsDivisibleByAllFactors(value))
            {
                value++;
            }

            return value;
        }


        static void Main(string[] args)
        {
            var multiple = Iteration();

            Console.WriteLine(string.Format("The smallest multiple of all integers from 1 to 20 is {0}", multiple));
            Console.ReadLine();

            // This works but is slow. You can find the lowest common multiple by breaking each factor down to it's primes (5*(2^2) = 20, 19 = 19, 2*(3^2) = 18 etc.) and picking out the greatest power of each prime
            // (i.e. so where 2 is put to the greatest power (2^4 since this appears in prime factorisation of 16), where 3 is put to the greatest power (3^2 since this appears in prime factorisation of 18) etc.)
            // and multiply these together (i.e. 2^4 * 3^2 * ...)

        }
    }
}
