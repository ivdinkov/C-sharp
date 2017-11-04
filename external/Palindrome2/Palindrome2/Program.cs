using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome2
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
            char[] a = v.ToCharArray();
            int l = a.Length - 1;

            for (int i = 0; i < l; i++)
            {
                if (a[i] != a[l-i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
