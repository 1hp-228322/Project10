using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class3
    {
        private int N;

        public Class3(int n)
        {
            N = n;
        }

        public string G1()
        {
            double V = 0;
            for (int i = 1; i <= N; i++)
            {
                V = V + Math.Pow(i, 2);
            }
            return $"Сумма квадратов чисел от 1 до {N} = {V}";
        }
    }
}
