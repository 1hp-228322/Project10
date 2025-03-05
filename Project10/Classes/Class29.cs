using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class29
    {
        public long CalculateProductOfSquares(int m, int n)
        {
            long product = 1;

            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    product *= i * i;
                }
            }

            return product;
        }
    }
}
