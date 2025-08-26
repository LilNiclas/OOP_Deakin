namespace question2
{
    class Eagle : Bird
    {

        public Eagle(string name, string diet, string location, double weight, int age, string colour, string species, double wingSpan)
            : base(name, diet, location, weight, age, colour, species, wingSpan)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The eagle is screeching");
        }

        public void Fly()
        {
            Console.WriteLine("The eagle is flying");
        }
        public override void Eat()
        {
            Console.WriteLine("The eagle eats 1lb of " + diet);
        }
        public override void LayEgg()
        {
            Console.WriteLine("The eagle is laying an egg");
        }
    }
}