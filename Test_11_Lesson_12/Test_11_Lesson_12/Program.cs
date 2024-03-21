using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Drawing;


//Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:

//метод, определяющий длину окружности по заданному радиусу;
//метод, определяющий площадь круга по заданному радиусу;
//метод, проверяющий принадлежность точки с координатами (x, y) кругу с радиусом r и координатами центра x0, y0.


namespace Test_11_Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese, enter radius");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Plese, enter x and y");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double length = Circle.GetLength(r);
            double square = Circle.GetSquare(r);
            string check = Circle.GetCheck(r, x, y);
         
            Console.WriteLine($"{length} \n{square} \n{check}");
            Console.ReadKey();

        }


    }
}
