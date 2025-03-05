using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class25
    {
        private int N;

        public Class25(int n)
        {
            N = n;
        }

        public long CalculateDifferenceOfSquares()
        {
            long sumOfSquares = 0;
            long squareOfSum = 0;

            for (int i = 1; i <= N; i++)
            {
                sumOfSquares += i * i; 
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;

            return squareOfSum - sumOfSquares;
        }
    }
}
