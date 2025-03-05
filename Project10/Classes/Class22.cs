using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class22
    {
        public long CalculateSquareOfDifference(int m, int n)
        {
            if (m > n)
            {
                throw new ArgumentException("m должно быть меньше или равно n");
            }

            long sum = 0;

            for (int i = m; i <= n; i++)
            {
                sum += i;
            }

            long difference = n - m;
            long squareOfDifference = difference * difference;

            return squareOfDifference;
        }
    }
}
