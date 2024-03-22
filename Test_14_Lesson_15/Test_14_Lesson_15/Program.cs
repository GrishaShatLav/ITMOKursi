using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Drawing;


/*
Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:

    метод void SetStart(int x) - устанавливает начальное значение
    метод int GetNext() - возвращает следующее число ряда
    метод void Reset() - выполняет сброс к начальному значению

Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.




*/

namespace Test_14_Lesson_15
{
    class Program
    {
        static void Main(string[] args)
        {

            ArithProgression arithProgression = new ArithProgression();
            arithProgression.SetStart(10);
            arithProgression.SetStep(2);
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            arithProgression.Reset();
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());

            Console.WriteLine("---------------------");

            GeomProgression geomProgression = new GeomProgression();
            geomProgression.SetStart(2);
            geomProgression.SetStep(2);
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            geomProgression.Reset();
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.ReadKey();
        }

    }


}
