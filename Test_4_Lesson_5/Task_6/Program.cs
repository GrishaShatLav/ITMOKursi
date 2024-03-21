using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Обязательная задача*. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида

//Задание не выполненно!!!

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                array[i,i] = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine();

            }

            Console.WriteLine();
            Console.Write(array[n, n]);

            Console.ReadKey();

        }
    }
}

