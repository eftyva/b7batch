using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class PrimeFinder
    {
        public int[] GetPrimes(int l, int u)
        {
            int number, i, x, j = 0;

            int[] counts = new int[u];

            for (number = l; number <= u; number++)
            {
                x = 0;

                for (i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                    {
                        x++;
                        break;
                    }
                }

                if (x == 0 && number != 1)
                {

                    counts[j] = number;
                    j++;
                }
            }
            return counts;
        }
    }
}