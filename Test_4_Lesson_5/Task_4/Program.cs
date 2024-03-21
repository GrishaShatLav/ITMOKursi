using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество   нечетных положительных элементов, стоящих на четных местах.

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);

                Console.Write("{0} ", array[i]);
                if (array[i] % 2 != 0)
                {
                    if (i % 2 != 0)
                        k++;
                    else
                        continue;
                }

            }
            Console.WriteLine();
            Console.WriteLine("The answer is = {0} ", k);
            Console.ReadKey();

        }
    }
}

