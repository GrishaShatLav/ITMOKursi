using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Обязательная задача*. Два треугольника заданы длинами своих сторон.
//Определить, площадь какого из них больше (создать метод для вычисления  площади  треугольника по длинам его сторон).  Для решения задачи можно использовать формулу Герона 
namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1;
            double s2;
            Console.WriteLine("Введите стороны первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
           
            double b1 = Convert.ToDouble(Console.ReadLine());
            
            double c1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите стороны второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());

            double b2 = Convert.ToDouble(Console.ReadLine());

            double c2 = Convert.ToDouble(Console.ReadLine());

            s1 = GetParamTrian(a1, b1, c1);
            s2 = GetParamTrian(a2, b2, c2);

            Console.WriteLine("Площадь первого = {0:F2}", s1);
            Console.WriteLine("Площадь второго = {0:F2}", s2);

            if (s1 > s2) Console.WriteLine("Площадь первого больше площади второго");
            else if (s1 < s2) Console.WriteLine("Площадь второго больше площади первого");
            else   Console.WriteLine("Площади равны");
            Console.ReadKey();

        }


        static double GetParamTrian(double a, double b, double c)
        {
            double p = (a+b+c)/2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
           
        }


    }
}