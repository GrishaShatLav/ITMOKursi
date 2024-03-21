using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Обязательная задача*. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются.
//Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).

namespace Test_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = Console.ReadLine();
            string str2 = "";
            foreach (char c in str)
            {
                str2 = c + str2;
               
            }
            Console.WriteLine(str2);

            string strN = str.ToLower();
            string str2N = str2.ToLower();
            Console.WriteLine(strN);
            Console.WriteLine(str2N);
            
            if (string.Compare(strN, str2N, CultureInfo.CurrentCulture, CompareOptions.IgnoreCase | CompareOptions.IgnoreSymbols) == 0)
            {
                Console.WriteLine("Это предложение является палиндромом");
            }
            else
                Console.WriteLine("Это предложение НЕ является палиндромом");
            Console.ReadKey();


        }


    }
}