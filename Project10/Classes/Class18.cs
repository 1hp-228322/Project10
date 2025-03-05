using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class18
    {
        public List<int> GetFirst100Primes()
        {
            List<int> primes = new List<int>();
            int count = 0;
            int num = 2;

            while (count < 100)
            {
                if (IsPrime(num))
                {
                    primes.Add(num);
                    count++;
                }
                num++;
            }

            return primes;
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
