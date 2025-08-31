using System;
namespace task_6_1
{
    class Bird
    {
        public string name
        {
            get; set;
        }

        public virtual void fly()
        {
            Console.WriteLine("Flap, Flap, Flap");
        }

        public override string ToString()
        {
            return "A bird called " + name;
        }
    }
}