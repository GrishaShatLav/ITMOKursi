using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Дано целое число в диапазоне 100–999. 

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hun = "сотни";
            string dec = "десятки";
            string dig = "единицы";
            string spek = "особые случаи";
            string res = "результат";
            Console.WriteLine("Введите целое число от 100 до 999");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 100 || n > 999)
            {
                Console.WriteLine("Некорректно введённые данные");
                Console.ReadKey();
            }
            else
            {
                int f = n / 100;
                int s = n / 10 % 10;
                int t = n % 10;

                




                switch (f)
                {
                    case 1:
                        hun = "сто";
                        break;
                    case 2:
                        hun = "двести";
                        break;
                    case 3:
                        hun = "триста";
                        break;
                    case 4:
                        hun = "четыреста";
                        break;
                    case 5:
                        hun = "пятьсот";
                        break;
                    case 6:
                        hun = "шестьсот";
                        break;
                    case 7:
                        hun = "семьсот";
                        break;
                    case 8:
                        hun = "восемьсот";
                        break;
                    case 9:
                        hun = "девятьсот";
                        break;
                    default:
                        break;
                }
                switch (s)
                {

                    case 2:
                        dec = "двадцать";
                        break;
                    case 3:
                        dec = "тридцать";
                        break;
                    case 4:
                        dec = "сорок";
                        break;
                    case 5:
                        dec = "пятьдесят";
                        break;
                    case 6:
                        dec = "шестьдесят";
                        break;
                    case 7:
                        dec = "семьдесят";
                        break;
                    case 8:
                        dec = "восемьдесят";
                        break;
                    case 9:
                        dec = "девяносто";
                        break;
                    default:
                        break;
                }
                switch (t)
                {

                    case 1:
                        dig = "один";
                        break;
                    case 2:
                        dig = "два";
                        break;
                    case 3:
                        dig = "три";
                        break;
                    case 4:
                        dig = "четыре";
                        break;
                    case 5:
                        dig = "пять";
                        break;
                    case 6:
                        dig = "шесть";
                        break;
                    case 7:
                        dig = "семь";
                        break;
                    case 8:
                        dig = "восемь";
                        break;
                    case 9:
                        dig = "девять";
                        break;
                    default:
                        break;
                }
                if (s == 1)
                {
                    switch (t)
                    {
                        case 1:
                            spek = "одиннадцать";
                            break;
                        case 2:
                            spek = "двенадцать";
                            break;
                        case 3:
                            spek = "тринадцать";
                            break;
                        case 4:
                            spek = "четырнадцать";
                            break;
                        case 5:
                            spek = "пятнадцать";
                            break;
                        case 6:
                            spek = "шестнадцать";
                            break;
                        case 7:
                            spek = "семнадцать";
                            break;
                        case 8:
                            spek = "восемнадцать";
                            break;
                        case 9:
                            spek = "девятнадцать";
                            break;
                    }
                    Console.WriteLine("{0} {1} ", hun, spek);

                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", hun, dec, dig);
                }


                
                Console.ReadKey();
            }
            
        }

    }
}