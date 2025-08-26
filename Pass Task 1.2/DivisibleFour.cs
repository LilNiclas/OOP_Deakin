using System;
namespace Task1_2
{
    class DivisibleFour
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n < 1)
            {
                Console.Write("Only positive number: ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= n; i++)
            {
                if (i % 4 == 0 && i % 5 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
