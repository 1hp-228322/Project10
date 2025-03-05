using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class23
    {
        public int CalculateSum()
        {
            int sum = 0;

            for (int i = -20; i <= 20; i++)
            {
                if (i < 0 && i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
