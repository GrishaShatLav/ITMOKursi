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



/*
Необходимо разработать программу для записи информации о товаре в текстовый файл в формате json.

Разработать класс для моделирования объекта «Товар». Предусмотреть члены класса «Код товара» (целое число), «Название товара» (строка), «Цена товара» (вещественное число).
Создать массив из 5-ти товаров, значения должны вводиться пользователем с клавиатуры.
Сериализовать массив в json-строку, сохранить ее программно в файл «Products.json».

*/

namespace Test_15_Lesson_16
{
    class Program
    {
        static void Main(string[] args)
        {
            
                const int n = 5;
                Item[] items = new Item[n];

                for (int i = 0; i < n; i++)

                   {
                   
                       Console.WriteLine("Enter Code");
                   
                       int code = Convert.ToInt32(Console.ReadLine());
                   
                       Console.WriteLine("Enter Name");
                   
                       string name = (Console.ReadLine());
                   
                       Console.WriteLine("Enter Price");
                       int price = Convert.ToInt32(Console.ReadLine());
                   
                       items[i] = new Item() { Code = code, Name = name, Price = price };
                   
                   }
                   

                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                string jsonString = JsonSerializer.Serialize(items, options);

                using (StreamWriter sw = new StreamWriter("../../../../Products.json"))
                {
                    sw.WriteLine(jsonString);
                }








        }

    }



}
