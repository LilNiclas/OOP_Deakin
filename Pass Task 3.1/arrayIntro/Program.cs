using System;
using System.Collections.Generic;
using System.Linq;
namespace task_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] myArray = new double[10];
            int size = myArray.Length;
            
            //Q1
            Console.WriteLine("QUESTION 1");
            myArray[0] = 1.0;
            myArray[1] = 1.1;
            myArray[2] = 1.2;
            myArray[3] = 1.3;
            myArray[4] = 1.4;
            myArray[5] = 1.5;
            myArray[6] = 1.6;
            myArray[7] = 1.7;
            myArray[8] = 1.8;
            myArray[9] = 1.9;

            Console.WriteLine("Index 0: " + myArray[0]);
            Console.WriteLine("Index 1: " + myArray[1]);
            Console.WriteLine("Index 2: " + myArray[2]);
            Console.WriteLine("Index 3: " + myArray[3]);
            Console.WriteLine("Index 4: " + myArray[4]);
            Console.WriteLine("Index 5: " + myArray[5]);
            Console.WriteLine("Index 6: " + myArray[6]);
            Console.WriteLine("Index 7: " + myArray[7]);
            Console.WriteLine("Index 8: " + myArray[8]);
            Console.WriteLine("Index 9: " + myArray[9]);


            //Q2
            Console.WriteLine("QUESTION 2");
            for (int i = 0; i < size; i++)
            {
                myArray[i] = i;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("The element at position " + i + " in the array is " + myArray[i]);
            }


            //Q3
            Console.WriteLine("QUESTION 3");
            int[] studentArray = {87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
            int total = 0;
            for (int i = 0; i < studentArray.Length; i++)
            {
                total += studentArray[i];
            }
            Console.WriteLine("The total marks for the sudent is: " + total);
            Console.WriteLine("This consist of " + studentArray.Length + " marks");
            Console.WriteLine("Therefore the average mark is " + ((double)total / studentArray.Length));
            
            
            //Q4
            string[] studentNames = new string[6];
            Console.WriteLine("Enter 6 student names:");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.Write("Enter name for student " + (i + 1) + ": ");
                studentNames[i] = Console.ReadLine();
            }
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": " + studentNames[i]);
            }
            


            //Q5
            double[] arrayValues = new double[10];
            double currentLargest, currentSmallest;
            for (int i = 0; i < arrayValues.Length; i++)
            {
                Console.Write("Enter an double value: ");
                arrayValues[i] = Convert.ToDouble(Console.ReadLine());
            }
            double minValue = arrayValues.Min();
            double maxValue = arrayValues.Max();
            Console.WriteLine("Smallest value: " + minValue);
            Console.WriteLine("Largest value: " + maxValue);
            foreach (int value in arrayValues)
            {
                Console.Write(value + ", ");
            }
            
            
            //Q6
            int[,] my2ndArray = new int[3, 4]
            {
                { 1, 2, 3, 4 },
                { 1, 1, 1, 1 },
                { 2, 2, 2, 2 }
            };

            int element = my2ndArray[2, 3];
            Console.WriteLine("Row 3, column 4: " + element);

            for (int i = 0; i < my2ndArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2ndArray.GetLength(1); j++)
                {
                    Console.Write(my2ndArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            

            //Q7
            List<string> myStudentList = new List<string>();
            Random randomValue = new Random();
            int randomNumber = randomValue.Next(1, 13);
            Console.WriteLine("You now need to add " + randomNumber + " students to your class list");
            for (int i = 0; i < randomNumber; i++)
            {
                Console.Write("Please enter the name of Student " + (i + 1) + ": ");
                myStudentList.Add(Console.ReadLine());
            }

            for (int i = 0; i < myStudentList.Count; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": " + myStudentList[i]);
            }
            
            
            //Q8
            int[] test = {1, 2, 3, 2, 1};
            Console.WriteLine("Is palindrome: " + Palindrome(test));
            

            //Q9
            var listA = new List<int> {1, 2, 2, 5};
            var listB = new List<int> {1, 3, 4, 5, 7};
            var mergedList = Merge(listA, listB);
            if (mergedList == null)
            {
                Console.WriteLine("Returned null, make sure the lists are sorted");
            }
            else
            {
                foreach (int number in mergedList)
                {
                    Console.WriteLine(number);
                } 
            }
           

            //Q10
            int[,] twoDemArray = new int[,]
            {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 },
                { 4, 6, 7, 9, 1, 0 }
            };
            int[] oddNumbers = ArrayConversion(twoDemArray);
            foreach (int oddNumber in oddNumbers)
            {
                Console.WriteLine(oddNumber);
            }
        }

        //Q8
        static bool Palindrome(int[] array)
        {
            if (array.Length < 1)
            {
                return false;
            }
            return array.SequenceEqual(array.Reverse());
        }

        //Q9
        static List<int> Merge(List<int> list_a, List<int> list_b)
        {
            bool isSortedA = list_a.SequenceEqual(list_a.OrderBy(x => x));
            bool isSortedB = list_b.SequenceEqual(list_b.OrderBy(x => x));

            if (!isSortedA || !isSortedB)
            {
                return null;
            }
            var mergedList = list_a.Concat(list_b).ToList();
            mergedList.Sort();
            return mergedList;
        }

        //Q10
        static int[] ArrayConversion(int[,] array)
        {
            List<int> oddNumbers = new List<int>();

            for (int column = 0; column < array.GetLength(1); column++)
            {
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    int value = array[row, column];
                    if (value % 2 != 0)
                    {
                        oddNumbers.Add(value);
                    }
                }
            }
            return oddNumbers.ToArray();
        }
    }
}