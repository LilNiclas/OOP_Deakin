using System;
namespace task_6_1
{
    class Penguin : Bird
    {
        public override void fly()
        {
            Console.WriteLine("Penguins cannot fly");
        }

        public override string ToString()
        {
            return "A penguin named " + base.name;
        }
    }
}