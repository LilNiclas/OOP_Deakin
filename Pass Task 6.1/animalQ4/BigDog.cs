using System;
namespace task_6_1_4
{
    public class BigDog : Dog
    {
        override public void Greeting()
        {
            Console.WriteLine("BigDog: Woow!");
        }
        new public void Greeting(Dog another)
        {
            Console.WriteLine("Woooooowwwww!");
        }
    }
}