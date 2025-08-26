using System;
namespace Task_2_1
{
    class CarProgram
    {
        static void Main(string[] args)
        {
            Car carsito = new Car(30.0);

            carsito.PrintFuelCost();
            carsito.AddFuel(10);
            carsito.Drive(150);
            Console.WriteLine("Total miles driven: " + carsito.GetTotalMiles());
        }
    }
}