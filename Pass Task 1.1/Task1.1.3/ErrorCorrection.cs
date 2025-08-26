// Task 1.1.3
using System;
namespace Task1_1
{
    class ErrorCorrection
    {
        static void Main(string[] args)
        {
            /* 1. Example
            int number = 50;
            if (number == 50) ; {
                Console.WriteLine(“Number is 50”);
            }
            */
            //The code has a semicolon after the if statement
            int number = 50;
            if (number == 50)
            {
                Console.WriteLine("Number is 50" + "\n");
            }



            /* 2. Example
            int number = 60;
            if (number >== 50 and number <== 100) {
                Console.WriteLine(“Number is more than or equal to 50 and less than or equal to 100”);
            }
            */
            //The condition is incorrect it && not "and" and the oprators are wrong it >= and <=
            int number2 = 60;
            if (number2 >= 50 && number2 <= 100)
            {
                Console.WriteLine("Number is more than or equal to 50 and less than or equal to 100" + "\n");
            }



            /* 3. Example
            public class Score {
                public static void main(String[] args) {
                    double score = 40;
                    if score > 40
                    {
                        Console.WriteLine("You passed the exam!");
                    } else score 40
                    {
                     Console.WriteLine("You failed the exam!");
                    }
                }
            }
            */
            // Class and main method is public. You need to do that in Java not C#. 
            // The if statement is missing parentheses, and else statment should have no condition.

            //class Score
            //{
            //static void Main(string[] args)
            //{
            double score = 40;
            if (score > 40) 
            {
                Console.WriteLine("You passed the exam!" + "\n");
            }
            else
            {
                Console.WriteLine("You failed the exam!" + "\n");
            }
            //}
            //}



            /* 4. Example
            Switch (n) {
            case 1: Console.WriteLine(“The number is 1”);
            case 2: Console.WriteLine (“The number is 2”); break;
            default: Console.WriteLine (“The number is not 1 or 2”);
            break;
            }
            */
            // n is not defined, switch shoulb be lowercase, and the first case is missing a break statement.
            Console.WriteLine("Enter 1 or 2: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            switch (number3)
            {
                case 1:
                    Console.WriteLine("The number is 1" + "\n");
                    break;

                case 2:
                    Console.WriteLine("The number is 2" + "\n");
                    break;

                default:
                    Console.WriteLine("The number is not 1 or 2" + "\n") ;
                    break;
            }



            /* 5. Example
            switch (n) {
            Case 1: Console.WriteLine (“A”); break;
            case2: Console.WriteLine (“B”); break;
            Default: Console.WriteLine (“C”); break;
            }
            */
            //n not defined, Case and Default should be lowercase, and there is no space between case and 2
            Console.WriteLine("Enter 1 or 2: ");
            int number4 = Convert.ToInt32(Console.ReadLine());
            switch (number4)
            {
                case 1:
                    Console.WriteLine("A");
                    break;

                case 2:
                    Console.WriteLine("B");
                    break;

                default:
                    Console.WriteLine("C");
                    break;
            }

        }
    }
}