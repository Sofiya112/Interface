using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class MyClass : IMyInterface
    {
        public double MyGetPI()
        {
            return Math.PI;
        }

        public int MyGetInt()
        {
            return 25;
        }

        public int MySquare(int x)
        {
            return (int)(x * x);
        }
        public double MySqrt(double x)
        {
            return (double)Math.Sqrt(x); 
        }


    }
}
