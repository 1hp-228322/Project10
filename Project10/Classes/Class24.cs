using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    class Class24
    {
        public int CalculateSum()
        {
            int sum = 0;

            for (int i = 1; i < 100; i++)
            {
                if (i % 4 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
