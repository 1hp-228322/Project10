using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class20
    {
        public long CalculateExpression(int n)
        {
            long result = 0;

            for (int i = 1; i <= n; i++)
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
