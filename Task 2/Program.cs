using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine($"Метод, возвращающий число PI: {myClass.MyGetPI()}");

            Console.WriteLine($"Метод, возвращающий число типа int: {myClass.MyGetInt()}");

            Console.WriteLine($"Метод, возвращающий x в квадрате: {myClass.MySquare(5)}");

            Console.WriteLine($"Метод, возвращающий корень из x: {myClass.MySqrt(25)}");

            Console.ReadLine();


        }
    }
}
