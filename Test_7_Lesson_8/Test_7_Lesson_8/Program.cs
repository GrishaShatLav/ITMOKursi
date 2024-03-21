using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Обязательная задача*. Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.

namespace Test_8
{
    class Program
    {

        static void Main(string[] args)
        {

            string path = @"S:\BGP";
            string[] files = Directory.GetFiles(path,"", SearchOption.AllDirectories); ;
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }


            Console.ReadKey();


        }
    }
}
