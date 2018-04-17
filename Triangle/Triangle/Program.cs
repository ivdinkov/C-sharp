using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isTriangleNumber(3126250));
            Console.ReadLine();
        }
        public static bool isTriangleNumber(long number)
        {

            for (long i = 1;i<number ; ++i)
            {
                if (number == i * (i + 1) / 2)
                    return true;
            }
            return false;
        }
    }
}
