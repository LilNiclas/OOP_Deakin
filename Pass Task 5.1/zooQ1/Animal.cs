using System;
namespace question1
{
    class Animal
    {
        private string name;
        private string diet;
        private string location;
        private double weight;
        private int age;
        private string colour;

        public Animal(string name, string diet, string location, double weight, int age, string colour)
        {
            this.name = name;
            this.diet = diet;
            this.location = location;
            this.weight = weight;
            this.age = age;
            this.colour = colour;
        }

        public void eat()
        {
            Console.WriteLine(name + " is eating " + diet);
        }

        public void sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }

        public void makeNoise()
        {
            Console.WriteLine(name + " is making noise");
        }

        public void makeTigerNoise()
        {
            Console.WriteLine(name + " the tiger roars");
        }

        public void EagleNoise()
        {
            Console.WriteLine(name + " the eagle screeches");
        }

        public void makeWolfNoise()
        {
            Console.WriteLine(name + "  the wolf howls");
        }

        public void eatMeat()
        {
            Console.WriteLine(name + " is eating meat");
        }
        public void eatBerries()
        {
            Console.WriteLine(name + "  is eating berries");
        }
    }
}