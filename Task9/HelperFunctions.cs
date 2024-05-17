using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal static class HelperFunctions
    {
        public static int GetGdc(int a, int b)
        {
            if (a < b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            while (b != 0)
            {
                int temp = a % b;
                a = b;
                b = temp;
            }

            return a;
        }
    }
}
