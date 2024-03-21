using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_9_Lesson_10
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public int Gradus
        {
            get
            {
                return gradus;
            }

            set

            {
                if (value < 0 || value > 360)
                    Console.WriteLine("Gradus Error!");
                else
                    gradus = value;
            }

        }
        public int Min
        {
            get
            {
                return min;
            }

            set

            {
                if (value < 1 || value > 60)
                    Console.WriteLine("Min Error!");
                else
                    min = value;
            }

        }
        public int Sec
        {
            get
            {
                return sec;
            }

            set

            {
                if (value < 0 || value > 60)
                    Console.WriteLine("Sec Error!");
                else
                    sec = value;
            }

        }


        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public double ToRadians()
        {
            return (gradus  + (min  + sec/60)/60)*Math.PI/180;
        }
    }
}


