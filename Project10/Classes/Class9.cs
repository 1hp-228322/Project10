using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class9
    {
        private int N1;
        private int N;
        private int B = 0;
        public Class9(int n)
        {
            N = n;
            N1 = n;
        }

        public string G1()
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i < N; i++)
            {
                if (N % i == 0)
                {
                    numbers.Add(i);

                }
            }

            foreach (int n in numbers)
            {
                B = B + n;
            }

            if (B == N1)
            {
                return $"Число {N1} является совершенным, т.к.{(string.Join(" + ", numbers))} = {N}";
            }
            else
            {
                return $"Число {N1} не является совершенным";
            }
        }
    }
}
