using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "1 5 2 7 9";
            string s4 = "1 2 2";    
            string s = "1 2 1 1";   
            string s2 = "2 4 6 8 1";

            Console.WriteLine(GetOddOne(s));
            Console.ReadLine();
        }

        public static int GetOddOne(string s)
        {

            var list = s.Split(' ').Select(str => int.Parse(str)).ToList();
            var nList = list.Take(3);

            
            Console.WriteLine(true && true && false);
           

            //var found = /(mSum.Sum() % 2 == 0) ? list.First(f => f % 2 == 0) : list.ToList().First(f => f % 2 == 1 );
            return -1;// list.IndexOf(found)+1;

        }

    }
}
