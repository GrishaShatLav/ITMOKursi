using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Обязательная задача*. Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер стороны прямоугольника A");
            
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер стороны прямоугольника B");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер стороны квадрата  C");
            int C = Convert.ToInt32(Console.ReadLine());
            int SumHor = 0;
            int SumVer = 0;
            int Squares = 0;

            while (SumHor < A)
            {
                SumVer = 0;
                SumHor += C;
                
                while (SumVer < B)
                {
                    SumVer+=C;
                    Squares++;
                }
               

            }
            
            
            Console.WriteLine("Количество квадратов ={0} ", Squares);
            Console.ReadKey();
        }

    }
}