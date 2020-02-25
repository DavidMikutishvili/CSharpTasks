using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    class ClassTask
    {
    }
    abstract class BaseCar
    {
        public string BodyType { get; set; }
        public string Color { get; set; }
        //public string NumberOfWheels { get; set; }
        public string Make { get; set; }
        public BaseCar(string bodyType, string color, string make)
        {
            BodyType = bodyType; Color = color; Make = make;
        }
        public abstract void StartTheCar();
        public virtual void AddSpeed(int speed)
        {
            Console.WriteLine($"{Make} auto {Color} increased speed by {speed} km/h");
        }
        public virtual void DecriseSpeed(int speed)
        {
            Console.WriteLine($"{Make} auto {Color} reduced speed by {speed} km/h");
        }
    }
    class BMW : BaseCar
    {
        public string Model { get; set; }
        public BMW(string bodyType, string color, string make, string model)
            : base (bodyType, color, make)
        {
            Model = model;
        }

        public override void StartTheCar()
        {
            Console.WriteLine($"The engine of the new {Make} {BodyType} started");
        }
        public override void AddSpeed(int speed)
        {
            Console.WriteLine($"{Make} {Model} auto {Color} increased speed by {speed} km/h");
        }
    }
    class Audi : BaseCar
    {
        public string Model { get; set; }
        public Audi(string bodyType, string color, string make, string model)
            : base(bodyType, color, make)
        {
            Model = model;
        }

        public override void StartTheCar()
        {
            Console.WriteLine($"The engine of the new {Make} {BodyType} started");
        }
        public override void DecriseSpeed(int speed)
        {
            Console.WriteLine($"{Make} {Model} auto {Color} reduced speed by {speed} km/h");
        }
    }
}
