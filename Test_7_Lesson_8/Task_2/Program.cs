using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Обязательная задача*.
//Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
namespace Test_8
{
    class Program
    {

        static void Main(string[] args)
        {

            string path = @"S:\Temp\RandomNumbers.txt";
            Random rand = new Random();
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rand.Next(-10, 10));
                }
            }
            int k = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    k += Convert.ToInt32(sr.ReadLine());
                       
                }
            }
            Console.WriteLine(k);

            Console.ReadKey();


        }
    }
}
