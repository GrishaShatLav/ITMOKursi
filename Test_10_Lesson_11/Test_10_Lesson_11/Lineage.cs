using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_10_Lesson_11
{
    struct Lineage
    {
        double k;
        double b;
        

        public Lineage(double k, double b)
        {
            this.k = k;
            this.b = b;
            
        }

        public string Root()
        {
           
            if (k==0)
            {
                return "Решений нет";
            }
            else if (k==0 && b==0)
            {
                return "x - любое число";
            }
            double x = -b /k ;
           
            return $"x = {x}";
        }
    }
}
