using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySplit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = new int[] { 1, 2, 3, 4, 3, 2, 1 };
            int[] c = new int[] { 20, 10, 30, 10, 10, 15, 35 };
            int[] a = new int[] { 20, 10, -80, 10, 10, 15, 35 };
            int[] z = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            for (int i = 0; i < a.Length; i++)
            {
                var sum1 = a.Take(i).Sum();
                var sum = a.Skip(i+1).Take(a.Length-i).Sum();

                //Console.WriteLine(sum1 + "=" + i + "::" + a[i] + "="+sum);
                if (sum == sum1)
                    Console.WriteLine(i);
                else
                    Console.WriteLine("-1");
            }
           

            Console.ReadLine();
        }

        
    }
}
