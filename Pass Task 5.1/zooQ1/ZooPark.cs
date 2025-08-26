using System;
using System.Collections.Generic;

namespace question1
{
    class ZooPark
    {
        static void Main(string[] args)
        {
            Animal williamWolf = new Animal("William the wolf", "Meat", "Dog Village", 50.6, 9, "Gre7");
            Animal tonyTiger = new Animal("Tony the tiger", "Meat", "Cat Kingdom", 110, 6, "Orange and White");
            Animal edgarEagle = new Animal("Edgar the eagle", "Fish", "Bird World", 20, 15, "Black");

            williamWolf.makeWolfNoise();
            williamWolf.eatMeat();
            tonyTiger.makeTigerNoise();
            edgarEagle.EagleNoise();
        }
    }
}