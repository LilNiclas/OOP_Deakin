namespace question2
{
    class Lion : Feline
    {
        public Lion(string name, string diet, string location, double weight, int age, string colour, string species)
            : base(name, diet, location, weight, age, colour, species)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The lion is roaring");
        }

        public override void Eat()
        {
            Console.WriteLine("The lion eats 17lb of " + diet);
        }

        public override void Run()
        {
            Console.WriteLine("The lion is running in circles");
        }
        
        public override void Sleep()
        {
           Console.WriteLine("The lion is sleeping");
        }
    }
}