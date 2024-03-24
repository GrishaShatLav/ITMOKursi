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




namespace Test_22_Lesson_23
{
    class Program
    {



        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactorAsync(n);


            Console.ReadKey();

        }


        static void Factor(int n)
        {
            double s = 1;
            for (double i = 1; i <= n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);

        }

        static async void FactorAsync(int n)
        {
            await Task.Run(() => Factor(n));
        }

    }
}