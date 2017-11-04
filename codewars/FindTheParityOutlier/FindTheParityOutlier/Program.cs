using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheParityOutlier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] exampleTest1 = { 2, 6, 8, -10, 3 };
            int[] exampleTest2 = { 206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781 };
            Console.WriteLine(Find(exampleTest1));
            Console.ReadLine();
        }
        public static int Find(int[] integers)
        {
            return integers.GroupBy(i => i % 2).First(i => i.Count() == 1).First();            
        }


    }
}
