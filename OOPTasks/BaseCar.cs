using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks.OOPTasks
{
    abstract class BaseCar
    {
        public uint CurrentSpeed { get; private set; }
        public string BodyType { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }

        public BaseCar(string bodyType, string color, string make)
        {
            BodyType = bodyType;
            Color = color;
            Make = make;
        }

        public abstract void CarStart();

        public void AddSpeed(uint speed)
        {
            CurrentSpeed += speed;
            Console.WriteLine($"{Make} auto {Color} increased speed by {CurrentSpeed} km/h");
        }

        public virtual void DecriseSpeed(uint speed)
        {
            Console.WriteLine($"{Make} auto {Color} reduced speed by {speed} km/h");
        }
    }
}
