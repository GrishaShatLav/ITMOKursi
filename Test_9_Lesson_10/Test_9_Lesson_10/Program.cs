using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

//  Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
//  Реализовать класс, в котором указанные значения представлены в виде свойств. Для свойств предусмотреть проверку корректности данных.
//  Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
//  Создать объект на основе разработанного класса.
//  Осуществить использование объекта в программе.

namespace Test_9_Lesson_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Gradus, Min and Sec");
            int gradus_ = Convert.ToInt32(Console.ReadLine());
            int min_ = Convert.ToInt32(Console.ReadLine());
            int sec_ = Convert.ToInt32(Console.ReadLine());

            Angle angle = new Angle(gradus_, min_, sec_);

        


            double Radians = angle.ToRadians();
            Console.WriteLine(Radians);
            Console.ReadKey();


        }

    }


}