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

            resultList = ListFilterer.GetIntegersFromList(new List<object>() { 1, -2, "aasf", "1", "123", 123 });

            foreach (var item in resultList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
