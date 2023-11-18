using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myCar1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car1 Ford = new Car1("Mustang","white",2021,100);
            Car1 Opel = new Car1("Astra","blue",2020,120);

            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);
            Ford.fullThrottle();

            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.color);      
            Console.WriteLine(Opel.year);
            Opel.fullThrottle();

            Console.ReadKey();
        }
    }
}
