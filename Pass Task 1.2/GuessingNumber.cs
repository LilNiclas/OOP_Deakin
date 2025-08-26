using System;
namespace Task1_2
{
    class GuessingNumber
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("User 1 please pick a number between 1 and 10");
                int number = Convert.ToInt32(Console.ReadLine());
                while (number < 1 || number > 10)
                {
                    Console.WriteLine("Pick a number between 1 and 10.");
                    number = Convert.ToInt32(Console.ReadLine());
                }
                Console.Clear();

                Console.WriteLine("User 2 try and guess the number between 1 and 10");
                int guess = Convert.ToInt32(Console.ReadLine());
                while (guess != number)
                {
                    if (guess < number)
                    {
                        Console.WriteLine("Too low, guess higher");
                    }
                    else
                    {
                        Console.WriteLine("Too high, guess lower");
                    }
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("You have guessed the number! Well done!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("You can only enter integers" + "\n" + e.Message);
            }
            
        }
    }
}
