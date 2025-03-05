using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class6
    {
        private int N;

        public Class6(int n)
        {
            N = n;
        }

        public string G1()
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                if (i % 5 == 0)
                {
                    list.Add(i);
                }
            }
            return $"Кратные 5 числа от 1 до {N} = {(string.Join(" ", list))}";
        }
    }
}
