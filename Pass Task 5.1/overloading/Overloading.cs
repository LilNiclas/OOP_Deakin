using System;
namespace question1
{
    class Overloading
    {

        static void Main(string[] args)
        {
            methodToBeOverloaded("Alice");
            methodToBeOverloaded("Bob", 30);
        }

        public static void methodToBeOverloaded(string name)
        {
            Console.WriteLine("Name: " + name);
        }

        public static void methodToBeOverloaded(string name, int age)
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }
    }
}