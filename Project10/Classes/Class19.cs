    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class19
    {
        public long CalculateProductOfSquares(int m, int n)
        {
            long product = 1;

            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    product *= i * i;
                }
            }

            return product;
        }
    }
}
