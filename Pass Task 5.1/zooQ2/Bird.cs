namespace question2
{
    class Bird : AnimalWithInheritance
    {
        protected string species;
        protected double wingSpan;

        public Bird(string name, string diet, string location, double weight, int age, string colour, string species, double wingSpan)
            : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
            this.wingSpan = wingSpan;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The bird is chirping");
        }
        public override void Eat()
        {
            Console.WriteLine("The bird eats " + diet);
        }
        public virtual void LayEgg()
        {
            Console.WriteLine("The bird is laying an egg");
        }
    }
}