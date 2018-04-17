using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumber
{
    class Program
    {
        private static double k;

        static void Main(string[] args)
        {
            int[] z = new int[] { 0, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            for (int i = 0; i < z.Length; i++)
            {
                k += z[i] * Math.Pow(10, z.Length - i - 1);
            }

            Console.WriteLine($"{k:(0##) ###-####}");

            Console.ReadLine();
        }
    }
}
