using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class28
    {
        private int N;
        private int M;

        public Class28(int n, int m)
        {
            N = n;
            M = m;
        }

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

        public string FindNumbers()
        {
            List<int> result = new List<int>();

            for (int i = 1; i < N; i++)
            {
                int sumDigits = SumOfDigits(i);
                if (sumDigits * sumDigits == M)
                {
                    result.Add(i);
                }
            }

            return $"Числа меньше {N}, квадрат суммы цифр которых равен {M}:{(string.Join(" ", result))}";
        }
    }
}
