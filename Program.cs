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
            //BaseCar bmw = new BMW("sedan", "red", "BMW", "M5");
            //Audi audi = new Audi("SUV", "black", "Audi", "Q7");

            //bmw.StartTheCar();
            //audi.StartTheCar();
            //bmw.AddSpeed(80);
            //audi.DecriseSpeed(45);

            ArrayTasks arrayTasks = new ArrayTasks();
            arrayTasks.Palindrome();

            Console.ReadKey();
        }
    }
}
