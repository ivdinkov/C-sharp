using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars2
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1 = "aretheyhere";
            string st2 = "yestheyarehere";
            string res = "aehrsty";

            string outcome = Longest(st1,st2);

            Console.WriteLine(outcome);
            Console.ReadLine();
        }

        private static string Longest(string st1, string st2)
        {
            char[] a = (st1 + st2).ToCharArray();
            char[] result = a.Select(b => b).OrderBy(b => b).Distinct().ToArray();
            string s = new string (result);
            return s;
        }
    }
}
