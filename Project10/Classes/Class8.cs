using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class8
    {
        private int N;

        public Class8(int n)
        {
            N = n;
        }

        public string G1()
        {
            List<int> numbers = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41 };
            List<int> list = new List<int>();

            foreach (int n in numbers)
            {
                if (N % n == 0)
                {
                    list.Add(n);
                    N = N / n;
                }
            }
            return $"Число {N} разложено на простые числа = {(string.Join(" ", list))}";
        }
    }
}
