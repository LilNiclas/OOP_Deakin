using System;
namespace task_6_1_4
{
    public class Dog : Animal
    {
        override public void Greeting()
        {
            Console.WriteLine("Dog: Woof!");
        }
        public void Greeting(Dog another)
        {
            Console.WriteLine("Dog: Woooooooooof!");
        }
    }
}