using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks.OOPTasks
{
    internal class BMW : BaseCar, IExtraSpeed
    {
        public string Model { get; protected set; }

        public BMW(string bodyType, string color, string make, string model)
            : base(bodyType, color, make)
        {
            Model = model;
        }

        public override void CarStart()
        {
            Console.WriteLine($"The engine of the new {Make} {Model} {BodyType} started\n");
        }

        public void AddExtraSpeed(uint extraSpeed)
        {
            Console.WriteLine($"Current {Make} speed before calling the method is {CurrentSpeed}");

            CurrentSpeed += extraSpeed;

            Console.WriteLine($"After calling AddExtraSpeed({extraSpeed}) method, current speed is {CurrentSpeed}\n");
        }

        public override void DecriseSpeed(uint speed)
        {
            CurrentSpeed -= speed;
            base.DecriseSpeed(speed);
        }
    }
}
