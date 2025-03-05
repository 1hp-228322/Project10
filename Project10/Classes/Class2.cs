using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class2
    {
        private int N;

        public Class2(int n)
        {
            N = n;
        }

        public string G1()
        {
            int V = 1;
            for (int i = 1; i <= N; i++)
            {
                V = V * i;
            }
            return $"Факториал этого числа равен:{V}";
        }
    }
}
