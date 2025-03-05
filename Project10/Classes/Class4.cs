using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class4
    {
        private int N;

        public Class4(int n)
        {
            N = n;
        }

        public string G1()
        {
            double V = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    V = V + Math.Pow(i, 2);
                }
                else if (i % 3 == 0)
                {
                    V = V + Math.Pow(i, 3);
                }
            }
            return $"Сумма квадратов четных чисел и кубов нечетных чисел от 1 до {N} = {V}";
        }
    }
}
