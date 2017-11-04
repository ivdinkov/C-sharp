using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s = "navan";

            PalindromeChecker pch = new PalindromeChecker();

            if (pch.IsPallindrome(s))
            {
                Console.WriteLine("It is palindrome");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
            Console.ReadLine();
        }

    }
}
