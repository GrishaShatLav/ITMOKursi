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

/* Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора,  частотой  работы  процессора,  
 * объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством экземпляров, имеющихся в наличии.
 * Создать список, содержащий 6-10 записей с различным набором значений характеристик.

Определить:

- все компьютеры с указанным процессором. Название процессора запросить у пользователя;

- все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;

- вывести весь список, отсортированный по увеличению стоимости;

- вывести весь список, сгруппированный по типу процессора;

- найти самый дорогой и самый бюджетный компьютер;

- есть ли хотя бы один компьютер в количестве не менее 30 штук? */

namespace Test_18_Lesson_19
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Computer> computers = new List<Computer>()
            {
                                                                                     
                new Computer(){ Num = 1, Name = "Asus",    CPU = "IntelCore I9", Hz =3300, Memory = 4, SSD = 128 , VidMem =4, Price = 100 , Amount = 7 },
                new Computer(){ Num = 2, Name = "Acer",    CPU = "IntelCore I3", Hz =2400, Memory = 8, SSD = 256, VidMem = 8, Price = 150, Amount =30 },
                new Computer(){ Num = 3, Name = "Sumsung", CPU = "IntelCore I5", Hz =3000, Memory = 12, SSD = 1000, VidMem =8, Price = 200, Amount = 20 },
                new Computer(){ Num = 4, Name = "Dell",    CPU = "IntelCore I9", Hz =3200, Memory = 4, SSD = 512, VidMem= 12, Price = 70, Amount = 29},
                new Computer(){ Num = 5, Name = "Oklick",  CPU = "IntelCore I7", Hz =3400, Memory = 12, SSD = 512, VidMem =12, Price = 100, Amount = 40 },
                new Computer(){ Num = 6, Name = "Genius",  CPU = "IntelCore I9", Hz =2200, Memory = 32, SSD = 128, VidMem =4, Price = 70, Amount = 35 },
                new Computer(){ Num = 7, Name = "Kobra",   CPU = "IntelCore I3", Hz =2700, Memory = 8, SSD = 128, VidMem =8, Price = 20, Amount = 70},
               
            };

            Console.WriteLine("Enter CPU");
            string cpu = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.CPU == cpu).ToList();
            Print(computers1);

            Console.WriteLine("Enter Memory");
            int memory = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.Memory >= memory).ToList();
            Print(computers2);

            Console.WriteLine("Price sorting");
            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Print(computers3);

            Console.WriteLine("Groups");
            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.CPU);
            foreach (IGrouping<string, Computer> gr in computers4)
            {
                Console.WriteLine(gr.Key);
                foreach (Computer e in gr)
                {
                    Console.WriteLine($"Number ={e.Num} Name ={e.Name} CPU = {e.CPU} Hz ={e.Hz} Memory={e.Memory} SSD={e.SSD} Video Memory={e.VidMem} Price={e.Price} Amount={e.Amount}");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The most expencive and chipiest");
            
            Computer computers5 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"Number ={computers5.Num} Name ={computers5.Name} CPU = {computers5.CPU} Hz ={computers5.Hz} Memory={computers5.Memory} SSD={computers5.SSD} Video Memory={computers5.VidMem} Price={computers5.Price} Amount={computers5.Amount}");

            Computer computers6 = computers.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"Number ={computers6.Num} Name ={computers6.Name} CPU = {computers6.CPU} Hz ={computers6.Hz} Memory={computers6.Memory} SSD={computers6.SSD} Video Memory={computers6.VidMem} Price={computers6.Price} Amount={computers6.Amount}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("There is a computer with Amount 30 or higher. Is this true?");
            Console.Write("This is ");
            Console.Write(computers.Any(x => x.Amount >= 30));

            Console.ReadKey();


        }

        static void Print(List<Computer> computers)
        {
            foreach (Computer e in computers)
            {
                Console.WriteLine($"Number ={e.Num} Name ={e.Name} CPU = {e.CPU} Hz ={e.Hz} Memory={e.Memory} SSD={e.SSD} VideoMemory={e.VidMem} Price={e.Price} Amount={e.Amount}");
            }

            Console.WriteLine();
        }



    }
}