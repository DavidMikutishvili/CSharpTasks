using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks.OOPTasks
{
    class BMW : BaseCar, IExtraSpeed
    {
        public string Model { get; set; }
        public uint ExtraSpeed { get; set; }

        public BMW(string bodyType, string color, string make, string model, uint extraSpeed)
            : base(bodyType, color, make)
        {
            Model = model;
            ExtraSpeed = extraSpeed;
        }

        public override void CarStart()
        {
            Console.WriteLine($"The engine of the new {Make} {BodyType} started");
        }

        public void AddExtraSpeed()
        {
            Console.WriteLine(CurrentSpeed + ExtraSpeed);
        }
    }
}
