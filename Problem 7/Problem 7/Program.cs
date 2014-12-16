using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

        //What is the 10,001st prime number?

        public static bool IsPrime(long value)
        {
            for (long i = 2; i < (value / 2) + 1; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int Iteration()
        {
            var primeCounter = 2;

            var integer = 3;

            while (primeCounter < 10001)
            {
                integer++;

                if (IsPrime(integer))
                {
                    primeCounter++;
                }

            }

            return integer;
        }

        static void Main(string[] args)
        {
            var prime = Iteration();

            Console.WriteLine(string.Format("The 10,001st prime number is {0}", prime));
            Console.ReadLine();

        }
    }
}
