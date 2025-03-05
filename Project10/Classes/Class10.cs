using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class10
    {
        private double N, M;

        public Class10(double n, double m)
        {
            N = n; M = m;
        }

        public string G1()
        {
            double V = 0;
            for (double i = M; i <= N; i++)
            {
                V = V + Math.Pow(i, 2);
            }
            return $"Сумма квадратов чисел от {M} до {N} = {V}";
        }
    }
}
