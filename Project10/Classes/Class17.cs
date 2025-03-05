using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class17
    {
        private int N;

        public List<int> PrimeFactors(int N)
        {
            List<int> pf = new List<int>(N);

            for (int i = 2; i <= N; i++)
            {
                if (N % i == 0 && IsPrime(i))
                {
                    pf.Add(i);
                }
            }

            return pf;
        }

        private bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
