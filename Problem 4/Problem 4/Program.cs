using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4
{
    class Program
    {
        //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

        //Find the largest palindrome made from the product of two 3-digit numbers.

        public static bool IsPalindromic(int value)
        {
            var valueAsString = value.ToString();

            var charArray = valueAsString.ToCharArray();
            Array.Reverse(charArray);

            var reversedString = new string(charArray);

            int reversedInt;

            var parsePossible = Int32.TryParse(reversedString, out reversedInt);

            if (reversedInt == value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static List<int> Iteration()
        {

            var palindromicProducts = new List<int>();

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    var product = j * i;

                    if (IsPalindromic(product))
                    {
                        palindromicProducts.Add(product);
                    }
                }
            }

            return palindromicProducts;
        }

        static void Main(string[] args)
        {
            var palindromes = Iteration();

            Console.WriteLine(string.Format("The largest palindromic number made from the product of two 3-digit numbers is {0}", palindromes.Max()));
            Console.ReadLine();

        }
    }
}
