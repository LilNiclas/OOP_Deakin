namespace question2
{
    class Feline : AnimalWithInheritance
    {
        protected string species;

        public Feline(string name, string diet, string location, double weight, int age, string colour, string species)
            : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }

        public override void Sleep()
        {
            Console.WriteLine("The feline is sleeping");
        }
    }
}