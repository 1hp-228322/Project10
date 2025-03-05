using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class5
    {
        private int N;

        public Class5(int n)
        {
            N = n;
        }

        public string G1()
        {
            int S = 0;
            double V = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 5 != 0 && i % 3 == 0)
                {
                    S++;
                    V = V + i;
                }
            }

            if (S == 0)
            {
                return "Нет чисел не кратных пяти и кратных 3";
            }
            else if (V % 5 != 0 && V % 3 == 0)
            {
                return $"Сумма чисел от 1 до {N} кратных 3 и не кратных 5, также кратна 3 и не кратна 5 и равна = {V}";
            }
            else
            {
                return "Сумма чисел удовлетворяющих условию не кратна 3 или/и кратна 5";
            }
        }
    }
}
