using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{

    public class Class1
    {
        private int N;
        private double A;

        public Class1(double a, int n)
        {
            A = a; N = n;
        }

        public string G1()
        {
            double V = Math.Pow(A, N);
            return $"Ответ:{V}";
        }
    }
}
