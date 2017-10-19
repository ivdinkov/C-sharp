using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntOnlyListFilterLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> resultList;

            resultList = ListFilterer.GetIntegersFromList(new List<object>() { 1, 2, "a", "b" });

            foreach (var item in resultList)
            {
                Console.WriteLine(item + Environment.NewLine);
            }

            Console.ReadLine();
        }
    }
}
