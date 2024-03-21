using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Смоделируйте работу простого калькулятора.
//Программа должна запрашивать 2 числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
//После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.
namespace Test_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0 ;
            int r = 0;
            try
            {
                Console.WriteLine("Please, Enter Two Numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, The Operation Code!");
            Console.WriteLine("1 - addition");
            Console.WriteLine("2 - subtruction");
            Console.WriteLine("3 - multiplication");
            Console.WriteLine("4 - division");
             
             x = Convert.ToInt32(Console.ReadLine());

            if (x == 1) { r = a + b; Console.WriteLine("Result = {0}", r); }
            if (x == 2) { r = a - b; Console.WriteLine("Result = {0}", r); }
            if (x == 3) { r = a * b; Console.WriteLine("Result = {0}", r); }
            if (x == 4) { r = a / b; Console.WriteLine("Result = {0}", r); }


            else
              {
                    Console.WriteLine("Wrong Operation Code");

              }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          



        }
    }
}