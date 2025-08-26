// Task 1.1.5
using System;
namespace Task1_1
{
    class Microwave
    {
        static void Main(string[] args)
        {
            try
            {
                // No. items
                Console.Write("Enter the number of items you wish to microwave (1 to 3): ");
                int items = Convert.ToInt32(Console.ReadLine());
                if (items < 1 || items > 3)
                {
                    throw new ArgumentException("Number of items must be between 1 and 3");
                }

                // Heating time
                Console.Write("Enter the heating time for a single item (in seconds): ");
                int timePerItem = Convert.ToInt32(Console.ReadLine());

                double recommendedTime;

                if (items == 1)
                {
                    recommendedTime = timePerItem;
                }
                else if (items == 2)
                {
                    recommendedTime = timePerItem * 1.5;
                }
                else
                {
                    recommendedTime = timePerItem * 2;
                }
                //Print the recommended time
                Console.WriteLine("We recommend microwaving for " + recommendedTime + " seconds");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Not a valid number." + "\n" + "Error: " + e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Invalid input: " + e.Message);
            }
        }
    }
}