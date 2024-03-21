using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.
namespace Test_8
{
    class Program
    {
        //Задание выполненно НЕПОЛНОСТЬЮ
        static void Main(string[] args)
        {

            string path = @"S:\Temp\GreatPoetry.txt";
            
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(Console.ReadLine());
            }
            int L;
            int k=0;
            int c=0;

            string Sp;
            using (StreamReader sr = new StreamReader(path))
            {
                L = sr.ReadLine().Length;
                Sp = sr.ReadLine();
                string[] strArray = Sp.Split();
                foreach (string s in strArray)
                {
                    k++;

                }
            }
            Console.WriteLine("Количество символов = {0}",L);
            Console.WriteLine("Количество слов = {0}",k);
            Console.WriteLine("Количество строк = {0}",c);

            Console.ReadKey();


        }
    }
}