// Task 1.1.1
using System;
namespace Task1_1
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number (as an integer): ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 1)
                {
                    Console.WriteLine("ONE");
                }
                else if (number == 2)
                {
                    Console.WriteLine("TWO");
                }
                else if (number == 3)
                {
                    Console.WriteLine("THREE");
                }
                else if (number == 4 || number == 3)
                {
                    Console.WriteLine("FOUR");
                }
                else if (number == 5)
                {
                    Console.WriteLine("FIVE");
                }
                else if (number == 6)
                {
                    Console.WriteLine("SIX");
                }
                else if (number == 7)
                {
                    Console.WriteLine("SEVEN");
                }
                else if (number == 8)
                {
                    Console.WriteLine("EIGHT");
                }
                else if (number == 9)
                {
                    Console.WriteLine("NINE");
                }
                else
                {
                    Console.WriteLine("Write a number between 1 and 9");
                }
            }
            catch (FormatException e)
            {
                //If input can't be converted to an integer a format exception is thrown. Double and characters fail.
                Console.WriteLine("Not a valid number");
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}

