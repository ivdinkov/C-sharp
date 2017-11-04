using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeStringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            if (IsPalindrome("navan"))
            {
                Console.WriteLine("It is");
            }
            else
            {
                Console.WriteLine("it is not");
            }
            Console.ReadLine();
        }

        private static bool IsPalindrome(string v)
        {
            string x = "";
            for (int i = v.Length - 1; i >= 0; i--)
            {
                x += v[i];
            }
            return v == x;
        }
    }
}
