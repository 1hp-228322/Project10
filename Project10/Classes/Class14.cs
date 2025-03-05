using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project10.Classes
{
    public class Class14
    {
        double M;

        public Class14(double m)
        {
            M = m;
        }

        public string G1()
        {
            double V = 0;

            if (M >= 100 && M <= 800)
            {
                V = (800 - 100) - M;
                return $"Кол-во трехзначных чисел после М = {V}";
            }
            else
            {
                return "Число не входит в диапазон 100 - 800";
            }
            
            
        }
    }
}
