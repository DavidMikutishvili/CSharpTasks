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
            BMW bmw = new BMW("sedan", "red", "BMW", "M5", 2);
            BaseCar audi = new Audi("sedan", "black", "Audi", "a6", 2);

            bmw.AddSpeed(50);
            bmw.AddExtraSpeed();
            // audi.AddExtraSpeed(); - not avalible with BaseCar



            //ArrayTasks arrayTasks = new ArrayTasks();
            //arrayTasks.Palindrome();

            Console.ReadKey();
        }
    }
}
