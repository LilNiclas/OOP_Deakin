
/*
using System;
namespace Task1_2
{
    class ExistingIssues
    {
        static void Main(string[] args)
        {

            /* Issue 1
            int c = 0, product = 0;
            while (c <= 5)
                product = product * 5;
                c = c + 1;
            
            There is no curly braces so only the first line after is read inside the loop. C 
            is never changed, leading to the condition always being true and an infinite loop.  
            Product starts at 0, so doing “product * 5” will always lead to 0 
            
            int c = 0, product = 1;
            while (c <= 5)
            {
                product = product * 5;
                c = c + 1;
            }


            Issue 2
            int a = 31, b = 0, sum = 0;
            while (a != b) {
                sum = sum + a;
                b = b + 2;
            }

            B will never become the same value as A, so this will become an infinite loop.  
            
            int a = 31, b = 0, sum = 0; 
            while (a != b) { 
                sum = sum + a; 
                b = b + 1; 
            }

            Issue 3
            int x = 1;
            int total;
            while (x <= 10) {
                total = total + x;
                x = x + 1;
            }

            total is never initialized 
            
            int x = 1; 
            int total = 0; 
            while (x <= 10) { 
                total = total + x; 
                x = x + 1; 
            } 

            Issue 4
            while (y < 10) {
                int y = 0;
                Console.WriteLine(“y” + y);
                y = y + 1;
            }
            y is initialized inside the while loop. It needs to be before it. 
            
            int y = 0; 
            while (y < 10) { 
                Console.WriteLine("y " + y); 
                y = y + 1; 
            } 

            Issue 5 
            int z = 0;
            while (z > 0) {
                z = z ‐ 1;
                Console.WriteLine("z: " +z);
            }
            the condition is never met, it will always be false.
            
            int z = 5; 
            while (z > 0) { 
                z = z - 1; 
                Console.WriteLine("z: " + z); 
            } 
            
            Issue 6 
            for(int count = 1, count < 100, count++) {
                Console.WriteLine("Hello");
            }
            There needs to be a semicolon after the initialized int count = 1; not a 
            comma 
            
            for (int count = 1; count < 100; count++) {
                Console.WriteLine("Hello");
            } 
        
            Issue 7 
            for(int I =1; i>10; i++) {
                if (i>2) {
                    Console.WriteLine (“Flower”);
                }
            }
            the variable should not be cast in capslock, thats only for constants. The 
            naming of I is inconsistent. i>10 will always be false and the loop will never run. 
            The wrong quotation marks are used. 
            
            for (int i = 1; i < 10; i++) { 
                if (i > 2) { 
                    Console.WriteLine("Flower"); 
                } 
            }
            
        }
    }
}


*/