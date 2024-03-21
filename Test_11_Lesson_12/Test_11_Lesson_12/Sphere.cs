using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_11_Lesson_12
{
    static class Circle
    {
        static public double GetLength(double r)
        {
            return Math.PI*2*r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI * r * r;
        }
        static public string GetCheck(double r, double x, double y)
        {
            double hypotenuse = Math.Sqrt(x * x + y * y);
            if (hypotenuse <= r) { return "Точка принадлежит кругу"; }
            else
            { return "Точка НЕ принадлежит кругу"; }
        }
    }
}
