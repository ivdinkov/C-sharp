using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class PalindromeChecker
    {
        public bool IsPallindrome(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
            char[] x = s.ToCharArray();
            int i = 0, j = x.Length - 1;

            while (i < j)
            {
                if (!x[i].Equals(x[j]))
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
