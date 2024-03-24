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




namespace Test_21_Lesson_22
{
    class Program
    {



        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);

            Func<Task<int[]>, int[]> func2 = new Func<Task<int[]>, int[]>(SummArray);
            Task<int[]> task2 = task1.ContinueWith<int[]>(func2);

            Action<Task<int[]>> action = new Action<Task<int[]>>(MaxArray);
            Task task3 = task2.ContinueWith(action);


            task1.Start();
            Console.ReadKey();

        }


        static int[] GetArray(object a)
        {
            int n = (int)a;
            int[] array = new int[n];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 100);
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            return array;
        }

        static int[] SummArray(Task<int[]> task)
        {
            int s = 0;
            int[] array = task.Result;
            for (int i = 0; i < array.Count() ; i++)
            {
                s += array[i];
            }
            Console.WriteLine($"Summ ={s}");
            return array;

            
        }

        static void MaxArray(Task<int[]> task)
        {
            int[] array = task.Result;
            int max = array[1];
            
            for (int i = 0; i < array.Count() - 1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                
            }
            Console.WriteLine($"Max ={max}");



        }

    }
}