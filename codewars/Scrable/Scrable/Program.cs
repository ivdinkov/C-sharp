using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrable
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "scriptingjav";
            string s2 = "javascript";

            Console.WriteLine(Scramble(s1, s2));
            Console.ReadLine();

        }
        public static bool Scramble(string str1, string str2)
        {
            var grouped = str2
                     .GroupBy(s => s)
                     .Select(g => new { Symbol = g.Key, Count = g.Count() });

            foreach (var key in grouped)
            {
                if (str1.Contains(key.Symbol)) { 
                    if (!(key.Count <= str1.Count(w => w == key.Symbol)))
                        return false;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
