using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "1 5 2 7 9";
            string s4 = "0 1 2 48";
            string s = "1 2   101 0";
            string s2 = "2 4 6 8 1";

            Console.WriteLine(GetOddOne(s));
            Console.ReadLine();
        }

        public static int GetOddOne(string s)
        {
            string n = " 9 31 27 93 17 77 75 9 9 53 89 39 51 99 5 1 11 39 27 49 91 17 27 79 81 71 37 75 35 13 93 4 99 55 85 11 23 57 5 43 5 61 15 35 23 91 3 81 99 85 43 37 39 27 5 67 7 33 75 59 13 71 51 27 15 93 51 63 91 53 43 99 25 47 17 71 81 15 53 31 59 83 41 23 73 25 91 9 ";
            string h = " 79 27 77 57 37 45 27 49 65 33 57 21 71 19 75 85 65 61 23 97 85 9 23 1 9 3 99 77 77 21 79 69 15 37 15 7 93 81 13 89 91 31 45 93 15 97 55 80 85 83 ";

            var arr = n.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(str => int.Parse(str))
                .Select(str => str % 2 == 0 ? 1 : 0)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr[i + 1] || arr[i+1] != arr[i + 2])
                {
                    if (arr[i] == arr[i + 1])
                    {
                        return i + 3;
                    }
                    else if (arr[i + 1] == arr[i + 2])
                    {
                        return i + 1;
                    }
                    else
                        return i + 2;
                }

            }

            return -1;

            //var nums = numbers.Split(' ').Select((s, i) => new { Value = int.Parse(s), Index = i });
            //var even = nums.Where(x => x.Value % 2 == 0);
            //var odd = nums.Where(x => x.Value % 2 == 1);
            //return even.Count() == 1 ? even.First().Index + 1 : odd.First().Index + 1;

        }

    }
}
