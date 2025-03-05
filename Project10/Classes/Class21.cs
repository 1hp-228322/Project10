using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class21
    {
        public long CalculateDifferenceOfCubes(int N)
        {
            long sumOfCubes = 0;
            long sumOfNumbers = 0;

            for (int i = 1; i <= N; i++)
            {
                int oddNumber = 2 * i - 1;
                sumOfNumbers += oddNumber;
                sumOfCubes += oddNumber * oddNumber * oddNumber;
            }

            return sumOfCubes - sumOfNumbers;
        }
    }
}
