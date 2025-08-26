using System;

namespace question2
{
    class Penguin : Bird
    {
        public Penguin(string name, string diet, string location, double weight, int age, string colour, string species, double wingSpan)
            : base(name, diet, location, weight, age, colour, species, wingSpan)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The penguin squawks");
        }

        public override void Eat()
        {
            Console.WriteLine("The penguin eats 2lbs of " + diet);
        }

        public void Swim()
        {
            Console.WriteLine("The penguin is swimming in the water");
        }

        public override void LayEgg()
        {
            Console.WriteLine("The penguin lays an egg on the ice");
        }
    }
}
