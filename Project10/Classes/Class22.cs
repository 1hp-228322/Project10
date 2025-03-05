using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class22
    {
        private int M;
        private int N;

        public Class22(int m, int n) 
        {
            M = m; N = n;
        }

        public long CalculateSquareOfDifference()
        {
            if (M > N)
            {
                throw new ArgumentException("m должно быть меньше или равно n");
            }

            long sum = 0;

            for (int i = M; i <= N; i++)
            {
                sum += i;
            }

            long difference = N - M;
            long squareOfDifference = difference * difference;

            return squareOfDifference;
        }
    }
}
