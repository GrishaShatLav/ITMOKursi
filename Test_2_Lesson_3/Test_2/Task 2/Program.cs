using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//На числовой оси расположены три точки: A, B, C. 

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dot A");
            int A = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter dot B");
            int B = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter dot C");
            int C = Convert.ToInt32(Console.ReadLine());
            //distance calculating
            int disB = Math.Abs(B - A);
            int disC = Math.Abs(C - A);
            if (disB > disC)
            {
                Console.WriteLine("C is closer to and the distance between them is {0}", disC);
            }
            else if (disC > disB)
            {
                Console.WriteLine("B is closer to and the distance between them is {0}", disB);
            }
            else  
            {
                Console.WriteLine("C and B are both at the same distance from A, this distance being = {0}", disB);

             }
            
            Console.ReadKey();
        }

    }
}