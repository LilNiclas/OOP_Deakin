//Task 1.1.6
using System;
namespace Task1_1
{
    class DoCasting
    {
        static void Main(string[] args)
        {
            int sum = 17;
            int count = 5;

            //integer average
            int intAverage = sum / count;
            Console.WriteLine("intAverage: " + intAverage);

            //Double average without casting
            double doubleAverage = sum / count;
            Console.WriteLine("doubleAverage: " + doubleAverage);

            //Cast sum to double to get correct average
            double castedAverage = (double)sum / count;
            Console.WriteLine("castedAverage: " + castedAverage);
        }
    }
}