using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scramblies
{
    public class Scramblies
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
            //return str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x));

            var grouped = str2
                     .GroupBy(s => s)
                     .Select(g => new { Symbol = g.Key, Count = g.Count() });

            //foreach (var item in grouped)
            //{
            //    Console.WriteLine($"{item.Symbol}:{item.Count}");
            //}

            foreach (var key in grouped)
            {
                if (str1.Contains(key.Symbol))
                {
                    // Console.WriteLine($"{key.Symbol}:{key.Count}=>{key.Count<=str1.Count(w => w == key.Symbol)}");
                    //Console.WriteLine(key.Symbol);
                    if (!(key.Count <= str1.Count(w => w == key.Symbol)))
                        return false;
                }
                else
                    return false;
            }


            //for (int i = 0; i < str2.Length; i++)
            //{
            //    //Console.WriteLine($"{str2[i]}:{str2.Count(w => w == str2[i])}");
            //}
            return true;
        }
    }
}
