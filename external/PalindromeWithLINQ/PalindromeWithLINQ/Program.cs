using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeWithLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "navan";

            if (IsPalindrome(word))
            {
                Console.WriteLine("it is palindrome");
            }
            else
            {
                Console.WriteLine("it is not");
            }

            Console.ReadLine();
        }

        private static bool IsPalindrome(string word)
        {
            char[] a = word.ToCharArray();
            string n = "";

            foreach (var t in Enumerable.Reverse(a.ToList()))
            {
                n += t;
            }

            return n.Equals(word);
        }
    }
}
