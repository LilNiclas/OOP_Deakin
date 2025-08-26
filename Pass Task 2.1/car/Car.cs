using System;
namespace Task_2_1
{
    class Car
    {
        // Fields
        private double mpg;
        private double fuelInTank;
        private double totalMiles;

        private const double FUEL_COST_PER_LITRE = 1.385;

        // Constructor
        public Car(double mpg)
        {
            this.mpg = mpg;
            this.fuelInTank = 0;
            this.totalMiles = 0;
        }

        // Getters and Setters
        public double GetFuel()
        {
            return fuelInTank;
        }
        public double GetTotalMiles()
        {
            return totalMiles;
        }
        public void SetTotalMiles(double miles)
        {
            totalMiles = miles;
        }

        // Methods
        public void PrintFuelCost()
        {
            Console.WriteLine("Fuel cost per litre: " + FUEL_COST_PER_LITRE);
        }

        public double CalcCost(double litres)
        {
            return litres * FUEL_COST_PER_LITRE;
        }
        public double AddFuel(double litres)
        {
            fuelInTank += litres;
            double cost = CalcCost(litres);
            Console.WriteLine("Added "+ litres +" litres. Cost: " + cost);
            return cost;
        }

        public double ConvertToLitres(double gallons)
        {
            return gallons * 4.546;
        }

        public void Drive(double miles)
        {
            double gallonsUsed = miles / mpg;
            double litresUsed = ConvertToLitres(gallonsUsed);

            if (litresUsed > fuelInTank)
            {
                Console.WriteLine("You dont have enough fuel to drive that far");
                return;
            }

            fuelInTank -= litresUsed;
            totalMiles += miles;

            double tripCost = CalcCost(litresUsed);
            Console.WriteLine("Drove" + miles +" miles, used " + litresUsed + " litres");
            Console.WriteLine("Trip cost: " + tripCost);
        }
    }
}
