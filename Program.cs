using CSharpTasks.OOPTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            BMW bmw = new BMW("sedan", "red", "BMW", "M5");
            Audi audi = new Audi("sedan", "black", "Audi", "a6");

            bmw.CarStart();
            bmw.AddSpeed(20);
            bmw.AddExtraSpeed(15);
            bmw.DecriseSpeed(25);

            Console.WriteLine(bmw.Make + " current speed is now " + bmw.CurrentSpeed);

            Console.ReadKey();
        }
    }
}
