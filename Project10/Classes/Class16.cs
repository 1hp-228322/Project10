using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class16
    {
        private int P;
        private int Q;

        public Class16(int p, int q)
        {
            P = p;
            Q = q;
        }

        public Class16()
        {
        }

        public List<int> GetDividers(int q)
        {
            List<int> divisors = new List<int>();

            for (int i = 2; i <= Q; i++)
            {
                if (Q % i == 0)
                {
                    divisors.Add(i);
                }
            }
            return divisors;
        }

        public List<int> GetGeneralDivider()
        {
            List<int> dividers = GetDividers(Q);
            List<int> generalDevider = new List<int>();
            foreach (int divider in dividers)
            {
                if (P % divider != 0)
                {
                    generalDevider.Add(divider);
                }
            }

            return generalDevider;
        }

    }
}
