using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object of type Person
            Person Nurlybek = new Person("Nurlybek", 20);

            // uses SaysHello method with . accessor
            Nurlybek.SaysHello();

            Console.ReadKey();

        }
    }
}
