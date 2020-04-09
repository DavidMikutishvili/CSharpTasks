using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks.OOPTasks
{
    internal abstract class BaseCar
    {
        public uint CurrentSpeed { get; protected set; }
        public string BodyType { get; protected set; }
        public string Color { get; protected set; }
        public string Make { get; protected set; }

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
            Console.WriteLine($"{Make} auto {Color} increased speed to {CurrentSpeed} km/h\n");
        }

        public virtual void DecriseSpeed(uint speed)
        {
            Console.WriteLine($"{Make} auto {Color} reduced speed by {speed} km/h\n");
        }
    }
}
