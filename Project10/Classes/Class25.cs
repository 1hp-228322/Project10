using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class25
    {
        public long CalculateDifferenceOfSquares(int N)
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
