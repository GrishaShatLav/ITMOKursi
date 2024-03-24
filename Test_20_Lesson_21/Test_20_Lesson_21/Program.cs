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
using System.Threading;


/*
 *  Имеется пустой участок земли (двумерный массив) и план сада, который необходимо реализовать. 
 *  Эту задачу выполняют два садовника, которые не хотят встречаться друг с другом. 
 *  Первый садовник начинает работу с верхнего левого угла сада и перемещается слева направо, сделав ряд, он спускается вниз. 
 *  Второй садовник начинает работу с нижнего правого угла сада и перемещается снизу вверх, сделав ряд, он перемещается влево. 
 *  Если садовник видит, что участок сада уже выполнен другим садовником, он идет дальше. Садовники должны работать параллельно. 
 *  Создать многопоточное приложение, моделирующее работу садовников.
 * 
 * 
 * 
 */

namespace Test_20_Lesson_21
{
    class Program
    {
        const int n = 4;

        static int[,] path = new int[n, n];



        static void Main(string[] args)
        {

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    path[i, j] = random.Next(2, 10);

                    Console.Write("{0} ", path[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Long work hours later");
            Console.WriteLine();
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thred = new Thread(threadStart);
            thred.Start();

            Gardner2();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write($"{path[i, j]} ");


                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }



        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -1;
                        Thread.Sleep(delay);

                    }
                }
            }



        }

        static void Gardner2()
        {

            
            for (int j = n - 1; j >= 0; j--)
            {
                for (int i = n - 1; i >= 0; i--)
                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -2;
                        Thread.Sleep(delay);
                    }
                }
            }



        }







    }

}
