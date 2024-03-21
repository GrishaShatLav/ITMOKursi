using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Обязательная задача*. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида

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

                for (int j = 0; j < n; j++)
                {
                    array[i, j] = ((i % 2 == 0 ) && ( j % 2 == 0)|| (i % 2 != 0) && (j % 2 != 0)) ? 1 : 0;
                    
                    Console.Write("{0} ", array[i, j]);
                }


                Console.WriteLine();

            }
            Console.WriteLine();
            
            Console.ReadKey();

        }
    }
}

