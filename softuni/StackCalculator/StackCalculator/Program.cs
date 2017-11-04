using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            string typed = Console.ReadLine();
            Stack<string> myStack = new Stack<string>();
            int d = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter number\nTo quit enter q or Q:");
                string inp = Console.ReadLine();
                if (inp == "q" || inp == "Q")
                {
                    break;
                }
                myStack.Push(inp);
            } while (true);

            while (myStack.Count != 0)
            {
                d += int.Parse(myStack.Pop());
            }

            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
