using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class27
    {
        public long CalculateProductOfCubes(int m, int n)
        {
            long product = 1;

            for (int i = m; i <= n; i++)
            {
                product *= i * i * i;
            }

            return product;
        }
    }
}
