using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;

//Разработать структуру для решения линейного уравнения 0=kx+b.
//Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
//Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры.
//Осуществить использование экземпляра в программе.
namespace Test_10_Lesson_11
{
    class Program
    {

        static void Main(string[] args)
        {
            double k = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());


            Lineage lineage = new Lineage(k, b);
            Console.WriteLine(lineage.Root());
            Console.ReadKey();
        }


    }




}