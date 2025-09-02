using System;
namespace task_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q2 - Polymorphism

            // Bird
            Bird bird1 = new Bird();
            Bird bird2 = new Bird();
            bird1.name = "Feathers";
            bird2.name = "Polly";

            Console.WriteLine(bird1.ToString());
            bird1.fly();
            Console.WriteLine(bird2.ToString());
            bird2.fly();

            // Penguin
            Penguin penguin1 = new Penguin();
            Penguin penguin2 = new Penguin();
            penguin1.name = "Happy Feet";
            penguin2.name = "Pingu";

            Console.WriteLine(penguin1.ToString());
            penguin1.fly();
            Console.WriteLine(penguin2.ToString());
            penguin2.fly();

            // Duck
            Duck duck1 = new Duck();
            Duck duck2 = new Duck();
            duck1.name = "Daffy";
            duck1.size = 15;
            duck1.kind = "Mallard";

            duck2.name = "Donald";
            duck2.size = 20;
            duck2.kind = "Decoy";

            Console.WriteLine(duck1.ToString());
            Console.WriteLine(duck2.ToString());

            // Add all birds to the list
            List<Bird> birds = new List<Bird>();
            birds.Add(bird1);
            birds.Add(bird2);
            birds.Add(penguin1);
            birds.Add(penguin2);
            birds.Add(duck1);
            birds.Add(duck2);

            birds.Add(new Bird() { name = "Birdy" });
            foreach (Bird bird in birds)
            {
                 Console.WriteLine(bird);
            }


            // Q3 - Covariance
            List<Duck> ducksToAdd = new List<Duck>()
            {
                duck1,
                duck2
            };

            IEnumerable<Bird> upcastedDucks = ducksToAdd;

            List<Bird> birds2 = new List<Bird>();
            birds2.Add(new Bird() { name = "Michael" });
            birds2.AddRange(upcastedDucks);

            foreach (Bird bird in birds2)
            {
                Console.WriteLine(bird);
            }
            
        }
    }
}