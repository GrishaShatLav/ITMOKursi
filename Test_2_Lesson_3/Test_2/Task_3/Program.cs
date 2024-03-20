using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Дано целое число в диапазоне 20–69, определяющее возраст (в годах). 

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст от 20 до 69");
            int A = Convert.ToInt32(Console.ReadLine());
            if (A<20 || A>69)
            { Console.WriteLine("Некорректно введённые данные");
                Console.ReadKey();
            }
            else { 
            int o = A % 10;
            switch(o)
            {
                case 0: 
                    Console.WriteLine("Возраст {0} лет", A)
                        ; break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Возраст {0} лет", A)
                        ; break;
                case 1:
                    Console.WriteLine("Возраст {0} год", A)
                        ; break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Возраст {0} года", A)
                        ; break;
                default:
                    break;
            }
            }




            Console.ReadKey();
        }

    }

}