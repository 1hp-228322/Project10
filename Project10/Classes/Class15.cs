using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class15
    {
        public bool B;
        List<double> result = new List<double>();
        public double number;

        public Class15(double m)
        {
            number = m;
        }
        public void IsPrime(double i)
        {
            if (i <= 1)
            {
                B = false;
            }
            else if (i == 2)
            {
                B = true;

            }
            else if (i % 2 == 0 && i  > 2 )
            {
                B = false;
            }
            else
            {
                B = true;
            }
            
            


            for (int i1 = 3; i1 * i1 <= i; i1 += 2)
            {
                if (i % i1 == 0)
                {
                    B = false;
                }
            }

            
        }

        public string G1()
        {
            double Number = number;
            for (double i = (Number-1); i >= 0; i--)
            {
                IsPrime(i);
                if (B == true)
                {
                    result.Add(i);
                }
            }
            return $"Все простые числа от 0 до {number} {(string.Join(" ", result))}";


        }
    }
}
