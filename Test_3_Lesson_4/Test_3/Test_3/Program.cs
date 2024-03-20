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
            Console.WriteLine("Введите целочсиленное число N>0");
            int N = Convert.ToInt32(Console.ReadLine());
            int Summ = 0;
            if (N < 0) 
            { Console.WriteLine("Ошибка! Неверные данные"); }

            for (int i = 1; i <=2*N-1; )
            {
                Summ += i ;
                i += 2;
                Console.WriteLine(Summ);
               
            }
            Console.ReadKey();
        }

    }
}