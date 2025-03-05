using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class12
    {

        public Class12()
        {
        }

        public string G1()
        {
            int V = 1;
            for (int i = -80; i <= 80; i++)
            {
                if (i % 2 != 0 && i % 7 == 0 && i % 1 == 0)
                {
                    V *= i;
                }

            }
            return $"Произведение нечетных и кратных 7 чисел от -80 до 80 = {V}";
        }
    }
}
