using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class28
    {
        private int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10; 
                number /= 10;
            }
            return sum;
        }

        public List<int> FindNumbers(int n, int m)
        {
            List<int> result = new List<int>();

            for (int i = 1; i < n; i++)
            {
                int sumDigits = SumOfDigits(i);
                if (sumDigits * sumDigits == m)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
