namespace question2
{
    class Wolf : AnimalWithInheritance
    {

        public Wolf(string name, string diet, string location, double weight, int age, string colour)
            : base(name, diet, location, weight, age, colour)
        {
        }

        public override void MakeNoise()
        {
            Console.WriteLine("The wolf is howling");
        }

        public override void Eat()
        {
            Console.WriteLine("Wolf eats 10lb of " + diet);
        }
        
        public override void Run()
        {
            Console.WriteLine("The wolf is running in a pack");
        }
        
    }
}