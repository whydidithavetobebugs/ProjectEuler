using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Problem_3
{
    class Program
    {
        //The prime factors of 13195 are 5, 7, 13 and 29.

        //What is the largest prime factor of the number 600851475143 ?

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

        public static List<long> Iteration(long input)
        {
            var possiblePrimeFactor = 2;

            var primeFactors = new List<long>();

            while (true)
            {
                if ((input % possiblePrimeFactor == 0) && (IsPrime(possiblePrimeFactor))) //If the input is exactly divisible by the test factor and the test factor is a prime number i.e. possiblePrimeFactor is in fact a prime factor...
                {
                    primeFactors.Add(possiblePrimeFactor);
                    if (possiblePrimeFactor == input)
                        break;
                    input = input / possiblePrimeFactor;//Divide the input by the prime factor
                    possiblePrimeFactor = 1;//Reset possiblePrimeFactor
                    if (IsPrime(input))
                    {
                        primeFactors.Add(input);
                        break;
                    }
                }

                if (possiblePrimeFactor == 2 || possiblePrimeFactor == 1)
                {
                    possiblePrimeFactor++;
                }
                else
                {
                    possiblePrimeFactor += 2;
                }
            }

            return primeFactors;
        }

        static void Main()
        {

            string userInput;
            long temp2;

            do
            {
                Console.WriteLine("Please enter the number you wish to find the prime factors of: ");
                userInput = Console.ReadLine();
            } while (!Int64.TryParse(userInput, out temp2));

            var input = Convert.ToInt64(userInput);

            var primeFactors = Iteration(input);

            Console.WriteLine(string.Format("The prime factors of {0} are: ", userInput));

            foreach (var factor in primeFactors)
            {
                Console.WriteLine(factor.ToString());
            }

            Console.WriteLine(string.Format("And hence the largest prime factor is {0}", primeFactors.Max().ToString()));

            Console.ReadLine();

        }
    }
}
