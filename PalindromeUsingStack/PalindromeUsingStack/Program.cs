using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "navanh";
            
            if (IsPalindrome(s))
            {
                Console.WriteLine("it is");
            }
            else
            {
                Console.WriteLine("it is not");
            }
            Console.ReadLine();
        }

        private static bool IsPalindrome(string s)
        {
            Stack<char> myStack = new Stack<char>();
            string e = "";

            for (int i = 0; i < s.Length; i++)
            {
                myStack.Push(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                e += myStack.Pop();
            }
            return s == e;
        }
    }
}
