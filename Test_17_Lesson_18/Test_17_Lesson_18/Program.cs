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




namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();

            Console.WriteLine(Check(str));

           Console.ReadKey();






        }

        static bool Check(string str)
        { 


            Stack<char> stack = new Stack<char>();

            Dictionary<char, char> sk = new Dictionary<char, char>
            {
                { '(',')' },
                { '[',']' },
                { '{','}' },

            };

            foreach(char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                    stack.Push(sk[c]);
                if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0|| stack.Pop()!=c)
                        return false;

                }

            }

            
            if (stack.Count == 0) 
                return true;
            else return false;
           

        }


    }


}