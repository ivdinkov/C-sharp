using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };
            int res = find_it(x);
            //var result = Convert.ToString(res, 2);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        public static int find_it(int[] seq)
        {
            var oddNumberKeyValue = seq
                .GroupBy(x => x)
                .Select(
                x => new
                {
                    Key = x.Key,
                    Value = x.Count() % 3
                });
            int[] odd = (from i in oddNumberKeyValue
                      where i.Value == 0
                      select i.Key).ToArray();

            //Console.WriteLine(odd[0]);
            return odd[0];
        }
    }
}
