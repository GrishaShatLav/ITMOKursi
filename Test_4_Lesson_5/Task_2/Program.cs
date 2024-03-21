using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 15;
            int[] array = new int[n];
            Random random = new Random();

            
            int s = 0;

            for (int i = 0; i <n; i++)
            {
                array[i] = random.Next(0, 50);

                Console.Write("{0} ", array[i]);
            }

            int min = array[0];
            int max = array[0];

            foreach (int a in array)
            {
                if (a > max)
                    max = a;


            }
            foreach (int j in array)
            {
                if (j < min)
                    min = j;

            }
            s = (max + min);


        
            Console.WriteLine();
            Console.WriteLine("min = {0} max = {1}",min, max);
            Console.WriteLine("Сумма максимума и минимума = {0}", (s));
            Console.ReadKey();


        }


    }
}