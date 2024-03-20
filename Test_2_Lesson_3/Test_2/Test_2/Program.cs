using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Обязательная задача*. Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям.

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Coordinats of the first dot");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Coordinats of the second dot");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Coordinats of the third dot");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());

            int xM = Math.Max(x1, x2);
            int yM = Math.Max(y1, y2);
          
            if (x1 == x2 && y1 == y3)
            {
                Console.WriteLine("Fourth dot is x= {0} and y ={1}", x3, y2);
            }
            else if(x1 == x2 && y2 == y3)
            {
                Console.WriteLine("Fourth dot is x= {0} and y ={1}", x3, y1);
            }
            else if(x1 == x3 && y1 == y2)
            {
                Console.WriteLine("Fourth dot is x= {0} and y ={1}", x2, y3);
            }
            else if(x1 == x3 && y3 == y2)
            {
                Console.WriteLine("Fourth dot is x= {0} and y ={1}", x2, y1);
            }
            else if(x2 == x3 && y3 == y1)
            {
                Console.WriteLine("Fourth dot is x= {0} and y ={1}", x1, y2);
            }
            else if(x2 == x3 && y2 == y1)
            {
                Console.WriteLine("Fourth dot is x= {0} and y ={1}", x1, y3);
            }
            else 
            {
                Console.WriteLine("Error! The lines are not parallel to the Axis!");
            }

            Console.ReadKey();
        }

    }
}