using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntOnlyListFilterLINQ
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {

            //IEnumerable<int> mList = listOfItems.OfType<int>();

            return listOfItems.OfType<int>();
        }
    }
}
