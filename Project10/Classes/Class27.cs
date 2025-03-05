using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class27
    {
        private int M;
        private int N;

        public Class27(int m, int n)
        {
            M = m;
            N = n;
        }

        public long CalculateProductOfCubes()
        {
            long product = 1;

            for (int i = M; i <= N; i++)
            {
                product *= i * i * i;
            }

            return product;
        }
    }
}
