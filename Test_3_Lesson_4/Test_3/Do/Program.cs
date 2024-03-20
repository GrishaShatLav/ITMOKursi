using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных.
namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int i = 0;
            int e = 0;

            do
            {
                Console.WriteLine("Введите целое число! Введите 0, чтобы закончить");
                N = Convert.ToInt32(Console.ReadLine());
                if (N > 0)
                    i++;
                if (N < 0)
                    e++;
                if (i < e)
                    Console.WriteLine("Отрицательных чисел больше");
                if (i > e)
                    Console.WriteLine("Положительных чисел больше");
                if (i == e)
                    Console.WriteLine("Чисел поровну");

            }
            while (N != 0);
            Console.WriteLine("Конец");
            Console.ReadKey();
        }

    }
}