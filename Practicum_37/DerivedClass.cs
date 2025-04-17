using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_37
{
    class DerivedClass : IInterface
    {
       public void Method()
       {
            Console.WriteLine("Метод  Method реализованный в классе DerivedClass");
       }
    }
}
