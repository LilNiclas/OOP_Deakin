using System;
namespace Task1_2
{
    class Repetition
    {
        static void Main(string[] args)
        {
            // Question 1
            int sum = 0;
            double average;
            int upperBound = 100;
            for (int i = 0; i <= upperBound; i++)
            {
                sum += i;
            }
            average = (double)sum / upperBound;
            //Console.WriteLine("Sum: " + sum + "\n" + "Average: " + average + "\n");

            // Question 2
            sum = 0;
            int number = 1;
            while (number <= upperBound)
            {
                sum += number;
                number++;
            }
            //in the while loop it says, "While this condition is true it will loop", For loop says, "For this number, do this until it reaches the upper bound".
            average = (double)sum / upperBound;
            //Console.WriteLine("Sum: " + sum + "\n" + "Average: " + average + "\n");

            // Question 3
            sum = 0;
            number = 1;
            do
            {
                sum += number;
                number++;
            } while (number <= upperBound);
            average = (double)sum / upperBound;
            Console.WriteLine("Q3 - Sum: " + sum + "\n" + "Average: " + average);
        }
    }
}