using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_12_Lesson_13
{
    sealed class MultiBuilding:Building
    {
        private int numFloors;
        int NumFloors
        {
            get
            { return numFloors; }
            set
            {

                if (value <= 0)
                {
                    Console.WriteLine("Number of Floors Error!!");
                }
                else
                    numFloors = value;


            }


        }

        public MultiBuilding(string adress, int length, int width, int height, int numFloors)
            :base(adress,length,width,height)   
        {
            this.NumFloors = numFloors;
        }
        public string Print()
        {
            string result = base.Print();
            result += $"  || Amount of Floors = {numFloors}";
            return result;
        }


    }
}
