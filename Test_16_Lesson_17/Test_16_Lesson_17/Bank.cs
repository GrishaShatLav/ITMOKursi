using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test_16_Lesson_17
{
    internal class Bank<T>
    {
        private T Num { get; set; }
        private int Balance { get; set; }
        private string Fio { get; set; }

        public string GetInfo()
        {
            return $"{Num} {Balance} {Fio}";

        }

        public void Input()
        {
            Console.WriteLine("Enter number");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Enter Balance");
            Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            Fio = (Console.ReadLine());
        }
    }
}

    
