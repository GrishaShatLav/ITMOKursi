using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_14_Lesson_15
{
    interface ISeries
    {
        void SetStart(int x);

        int GetNext();

        void Reset();
    }


    class ArithProgression : ISeries
    {
        int step;

        int startValue;

        int currentValue;

        public int GetNext()
        {
            currentValue+=step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue=startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void SetStep(int s)
        {

            step = s;
        }
    }

    class GeomProgression : ISeries
    {
        int step;

        int startValue;

        int currentValue;

        public int GetNext()
        {
            currentValue = currentValue * step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
        public void SetStep(int s)
        {

            step = s;
        }
    }
}
