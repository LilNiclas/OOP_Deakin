// Task 1.1.4
using System;
namespace Task1_1
{
    class CodeFragmentOutput
    {
        static void Main(string[] args)
        {
            /* Example 1
            int height = 13;
            if ( height <= 12 )            
                Console.WriteLine("Low bridge: ");

            Console.WriteLine ("proceed with caution.");
            */
            //proced with cuation. 
            //the if statement with no curly braces will only read first line
            //Height will never enter the if statement.
            //Unnecessary with 2 writelines            
            int height = 13;
            if (height <= 12)
            {
                Console.WriteLine("Low bridge: Proceed with caution" + "\n");
            }
            else
            {
                Console.WriteLine("Height is safe" + "\n");
            }



            /* Example 2
            int sum = 21;
            if ( sum != 20 )
                Console.WriteLine ("You win ");
            else
                Console.WriteLine ("You lose ");

            Console.WriteLine ("the prize.");
            */
            //You win the prize.
            //no curly braces after the else statement, so it will only include the first line as part of the if statement
            //I think its good practice to always use curly braces.
            //Write "the prize" in the other line
            int sum = 21;
            if (sum != 20)
            {
                Console.WriteLine("You win the prize" + "\n");
            }
            else
            {
                Console.WriteLine("You lose the prize" + "\n");
            }



            /* Example 3
            int sum = 7;
            if ( sum > 20 ) {
                Console.WriteLine ("You win ");
            } else {
                Console.WriteLine ("You lose ");
            }
            Console.WriteLine ("the prize.");
            */
            //You lose the prize.
            //It will print "You lose the prize" because the if statement is false, and the last line is outside of the if statement.
            //Include the last line in the else statement.
            int sum2 = 7;
            if (sum2 > 20)
            {
                Console.WriteLine("You win the prize");
            }
            else
            {
                Console.WriteLine("You lose the prize");
            }
        }
    }
}