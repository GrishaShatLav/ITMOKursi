using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Drawing;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Text.Json.Serialization;
using System.Xml.Linq;

/*Создать класс для моделирования счета в банке. 
 * Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
 * Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
 * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. Создать  несколько экземпляров класса, параметризированного различными типам. 
 * Заполнить его поля и вывести на экран информацию об экземпляре класса.*/


namespace Test_16_Lesson_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank<int> bank = new Bank<int>();
            bank.Input();
            Console.WriteLine(bank.GetInfo());
            Bank<string> bank2 = new Bank<string>();
            bank2.Input();
            Console.WriteLine(bank2.GetInfo());      
            Bank<double> bank3 = new Bank<double>();
            bank3.Input();
            Console.WriteLine(bank3.GetInfo());

            Console.ReadKey();

        }


    }


}
