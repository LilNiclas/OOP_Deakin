using System;
namespace question6 
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            ClassB b = new ClassB();

            b.PrintResults(3);
        }
        /*
        Question 1
        Does b, the instance of ClassB, have an instance variable i accessible?
        No, because i is private in ClassA. Only proteceted and public members are accessible in derived classes.

        Question 2
        Is the first call to Console.WriteLine in PrintResults in ClassB legal?
        No, it tries to access i directly, but i is private in ClassA

        Question 3
        Is the second call to Console.WriteLine in PrintResults in ClassB legal?
        Yes, because Sum is protected in ClassA, so it can be accessed in the subclass ClassB
        */
    }
}