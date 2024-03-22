using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test_12_Lesson_13
{
    internal class Building
    {
        private string adress;
        private int length;
        private int width;
        private int height;

        string Adress
        {
            get
            { return adress; }
            set
            {

               
           
               adress = value;


            }
        }

        int Length
        {
            get
            { return length; }
            set 
            { 
                
                 if(value <= 0)
                {
                    Console.WriteLine("Length Error!!");
                }
                 else
                    length = value;

            
            }
        }
        int Width
        {
            get
            { return width; }
            set
            {

                if (value <= 0)
                {
                    Console.WriteLine("Width Error!!");
                }
                else
                    width = value;


            }
        }
        int Height
        {
            get
            { return height; }
            set
            {

                if (value <= 0)
                {
                    Console.WriteLine("Height Error!!");
                }
                else
                    height = value;


            }


        }

        public Building(string adress, int length, int width, int height)
        {
            this.Adress = adress;
            this.Length = length;
            this.Width = width;
            this.Height = height;

        }
        public string Print()
        {

            return $"Adress - {adress} || Length = {length} || Width = {width} || Height = {height}";
        }






    }
}
