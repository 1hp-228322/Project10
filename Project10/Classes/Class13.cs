﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class13
    {
        private double N, M;

        public Class13(double n, double m)
        {
            N = n; M = m;
        }

        public string G1()
        {
            double V = 0;
            for (double i = M + 1; i < N; i++)
            {
                if (i % 2 != 0 && i % 7 == 0)
                {
                    V = V + Math.Pow(i, 2);
                }

            }
            return $"Сумма квадратов нечетных и кратных 7 чисел от {M} до {N} = {V}";
        }
    }
}
