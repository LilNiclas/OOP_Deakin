using System;
namespace question2
{
    class AnimalWithInheritance
    {
        protected string name;
        protected string diet;
        protected string location;
        protected double weight;
        protected int age;
        protected string colour;

        public AnimalWithInheritance(string name, string diet, string location, double weight, int age, string colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }

        public virtual void Eat()
        {
            Console.WriteLine("An animal is eating");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("An animal is sleeping");
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("An animal makes a noise is");
        }

        public virtual void Run()
        {
            Console.WriteLine("An animal is running");
        }
    }
}