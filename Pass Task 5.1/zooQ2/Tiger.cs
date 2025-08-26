namespace question2
{
    class Tiger : Feline
    {
        private string colourStripes;

        public Tiger(string name, string diet, string location, double weight, int age, string colour, string species, string colourStripes)
            : base(name, diet, location, weight, age, colour, species)
        {
            this.colourStripes = colourStripes;
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The tiger is roaring");
        }

        public override void Eat()
        {
            Console.WriteLine("The tiger eats 15lb of " + diet);
        }
        
        public override void Run()
        {
            Console.WriteLine("The tiger is running in rings");
        }
    }
}