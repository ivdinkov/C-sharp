using System;
using System.Text.RegularExpressions;

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
              k += z[i]*Math.Pow(10,z.Length-i-1);

                Console.WriteLine(z[i]);
                Console.WriteLine(Math.Pow(10, z.Length - i - 1));
                Console.WriteLine();
            }


            Console.WriteLine(k);

            Console.WriteLine($"{k:(0##) ###-####}");

            Console.WriteLine(new Regex("(...)(...)(....)").Replace(String.Concat(z), "($1) $2-$3"));

            long.Parse(string.Concat(z)).ToString("(000) 000-0000");

            Console.ReadLine();
        }
    }
}
