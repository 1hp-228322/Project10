using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class20
    {
        private int N;

        public Class20(int n)
        {
            N = n;
        }

        public long CalculateExpression()
        {
            long result = 0;

            for (int i = 1; i <= N; i++)
            {
                long term = 1;
                for (int j = i; j <= 2 * i; j++)
                {
                    term *= j;
                }
                result += term;
            }

            return result;
        }
    }
}
