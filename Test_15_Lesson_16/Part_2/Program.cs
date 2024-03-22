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
Необходимо разработать программу для получения информации о товаре из json-файла.
Десериализовать файл «Products.json» из задачи 1. Определить название самого дорогого товара.

*/

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {



            string jsonString = String.Empty;

            using (StreamReader sr = new StreamReader(" ../../../../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Item[] items = JsonSerializer.Deserialize<Item[]>(jsonString);

            Item maxItem = items[0];

            foreach (Item i in items)
            {
                if (i.Price > maxItem.Price)
                {
                    maxItem = i;
                }
            }
            Console.WriteLine($"Code = {maxItem.Code}  \nName = {maxItem.Name}  \nPrice = {maxItem.Price}");
            Console.ReadKey();





        }

    }



}
