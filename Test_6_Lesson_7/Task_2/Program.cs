using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Обязательная задача*. Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
namespace Test_6
{
    
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите размер ребра куба");
                double a = Convert.ToDouble(Console.ReadLine());
                double s;
                double v;
                GetParamsCube(a, out s, out v);
                Console.WriteLine("Объём = {0:F2} Площадь поверхности = {1:F2}", v, s);
                Console.ReadKey();

            }


            static void GetParamsCube(double a, out double s, out double v)
            {
                
                v = a*a*a;
                s = 6*a*a;
        }


        }

    
}