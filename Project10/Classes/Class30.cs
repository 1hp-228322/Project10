using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class30
    {
        private int M;
        private int N;

        public Class30(int m, int n)
        {
            M = m;
            N = n;
        }

        public long CalculateProductOfSquares()
        {
            long product = 1;

            for (int i = M; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    product += i * i;
                }
            }

            return product;
        }
    }
}
