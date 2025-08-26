using System;
using System.Collections.Generic;

namespace question2
{
    class ZooParkWithInheritance
    {
        static void Main(string[] args)
        {
            AnimalWithInheritance animal = new AnimalWithInheritance("Animal Name", "Animal Diet", "Animal Location", 0.0, 0, "Animal Colour");

            Tiger tonyTiger = new Tiger("Tony the tiger", "Meat", "Cat Kingdom", 110, 6, "Orange and White", "Siberian", "White");
            Wolf williamWolf = new Wolf("William the wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Eagle edgarEagle = new Eagle("Edgar the eagle", "Fish", "Bird World", 20, 15, "Black", "Harpy", 98.5);
            Lion leoLion = new Lion("Leo the lion", "Meat", "Savannah", 420, 8, "Golden", "African");
            Penguin peterPenguin = new Penguin("Peter the penguin", "Fish", "Arctic", 30, 4, "Black and White", "Emperor", 40.0);

            animal.MakeNoise();
            tonyTiger.MakeNoise();
            williamWolf.MakeNoise();
            edgarEagle.MakeNoise();
            leoLion.MakeNoise();

            Console.WriteLine();

            animal.Eat();
            tonyTiger.Eat();
            williamWolf.Eat();
            edgarEagle.Eat();
            leoLion.Eat();

            Console.WriteLine();

            animal.Sleep();
            tonyTiger.Sleep();
            williamWolf.Sleep();
            edgarEagle.Sleep();
            leoLion.Sleep();

            Console.WriteLine();

            tonyTiger.Run();
            williamWolf.Run();
            edgarEagle.Fly();
            leoLion.Run();
            peterPenguin.Swim();
        }
        
    }
}