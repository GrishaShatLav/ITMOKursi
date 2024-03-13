using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Circumference");
            double Circum = Convert.ToDouble(Console.ReadLine());
            double Radius = (double)Circum/(2*Math.PI);
            double Square = (double)Math.PI*Math.Pow(Radius, 2);
            Console.WriteLine("Radius = {0}", Radius);
            Console.WriteLine("Square = {0}", Square);
            Console.ReadKey();


        }
    }
}