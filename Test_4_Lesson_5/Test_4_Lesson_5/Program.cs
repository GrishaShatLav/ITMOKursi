using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Обязательная задача*. Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов.

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int s = 0;
            int k = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

                
                 s += array[i];
                 k++;
                

            }
            Console.WriteLine("Среднее арифметическое = {0:f2}", ((double)s) / k);
            Console.ReadKey();


        }


    }
}