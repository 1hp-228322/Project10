using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class7
    {
        private int N;

        public Class7(int n)
        {
            N = n;
        }

        public string G1()
        {
            double V = 0;
            V = Math.Log(N, 2);
            if (V > 0 && V % 1 == 0)
            {
                return $"Число {N} является степенью 2";
            }
            else
            {
                return $"Число {N} не является степенью 2";
            }
        }
    }
}
