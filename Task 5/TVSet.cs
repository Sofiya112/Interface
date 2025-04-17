using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class TVSet : ISwitchable
    {
        public void Inclusion()
        {
            Console.WriteLine("Включение телевизора");
        } 
        public void Shutdown()
        {
            Console.WriteLine("Выключение телевизора");
        }

    }
}
