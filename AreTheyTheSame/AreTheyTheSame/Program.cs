using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreTheyTheSame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {121, 144, 19, 161, 19, 144, 19, 11};
            int[] b = {121, 14641, 20736, 361, 25921, 361, 20736, 361};

            Console.WriteLine(comp(a,b));

            Console.ReadLine();
        }
        public static bool comp(int[] a, int[] b)
        {
            var aNew = a.ToList();
            var bNew = b.ToList();

            if (aNew.Count != bNew.Count)
                return false;
            else {
                for (int i = 0;i<aNew.Count;i++)
                {
                    if (b.ToList().Contains(a[i]*a[i]))
                    {
                        bNew.Where(s=>s==a[i]*a[])
                    }
                }
            }
            return true;
        }
    }
}
