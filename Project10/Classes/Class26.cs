﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class26
    {
        public Class26() 
        {

        }
        public string GetOddNumbers()
        {
            List<int> oddNumbers = new List<int>();

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumbers.Add(i);
                }
            }

            return $"Нечетные числа от 100 до 200:{(string.Join(" ", oddNumbers))}";
        }
    }
}
