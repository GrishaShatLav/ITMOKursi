using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Drawing;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using System;

/*
     В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:

-       метод получает входным параметром переменную типа double;

-       метод возвращает значение типа double, которое является результатом вычисления.

 

Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:

-       длину окружности по формуле D = 2 * π* R;

-       площадь круга по формуле S = π* R²;

-       объем шара. Формула V = 4/3 * π * R³.


Методы должны быть объявлены как статические.*/


namespace Test_19_Lesson_20
{
    class Program
    {

        delegate double MyDelegate(double r);


        static void Main(string[] args)
        {
            MyDelegate myDelegate = Length;
            double r = myDelegate(3);
            Console.WriteLine(r);


            myDelegate = Square;
            r = myDelegate(3);
            Console.WriteLine(r);

            myDelegate = Volume;
            r = myDelegate(3);
            Console.WriteLine(r);

        }



        static double Length(double r) =>( 2*Math.PI*r);
        static double Square(double r) =>(Math.PI*r*r);
        static double Volume(double r) =>(((double)4/3)*(Math.PI*r*r*r));





    }
}