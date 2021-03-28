using System;

namespace Car
{
    class Car
    {
        //Instance Variable
        private double fuelEfficiency, fuelInTank, totalMilesDriven, cost;
        //Constant Variable
        private const double PETROL_PRICE = 1.385;

        public Car(double fuelEfficiency)
        {
            this.fuelEfficiency = fuelEfficiency;
            this.fuelInTank = 0.0;
            this.totalMilesDriven = 0.0;
            this.cost = 0;
        }
        //Accessor Methods
        public double getFuel()
        {
            return this.fuelInTank;
        }
        public double getTotalMiles()
        {
            return this.totalMilesDriven;
        }
        public string totalCost()
        {
            return this.cost.ToString("C");
        }
        //Mutator Methods
        public void setTotalMiles(double totalMilesDriven)
        {
            this.totalMilesDriven = totalMilesDriven;
        }
        //Methods
        public void printFuelCost()
        {
            this.cost = PETROL_PRICE;
            Console.WriteLine(totalCost());
        }
        public void addFuel(double addFuelAmount)
        {
            this.fuelInTank += addFuelAmount;
            this.cost = addFuelAmount * PETROL_PRICE;
            Console.WriteLine("Current amount of fuel in tank: " + getFuel());
            Console.WriteLine("Cost of the fill: " + totalCost());
        }
        public void calcCost(double calcFuel)
        {
            this.cost = calcFuel * PETROL_PRICE;
            Console.WriteLine("Cost of fuel: " + totalCost());
        }
        public void convertToLitres(double gallons)
        {
            double litres = gallons * 4.546;
            Console.WriteLine(litres + " litres");
        }

        public void currentFuel()
        {
            Console.WriteLine("Current fuel is: " + getFuel());
        }
        public void drive(double milesDriven)
        {
            double fuelUsed = (milesDriven / this.fuelEfficiency) * 4.546;
            double fuelInTank = this.fuelInTank;

            if (fuelInTank > fuelUsed)
            {
                {
                    this.totalMilesDriven += milesDriven;
                    this.fuelInTank -= fuelUsed;
                    this.cost = fuelUsed * PETROL_PRICE;
                    Console.WriteLine("Current journey distance: " + milesDriven + (" miles"));
                    Console.WriteLine("Total Mileage on car: " + getTotalMiles() + (" miles"));
                    Console.WriteLine("Total fuel used for this journey in litres: " + fuelUsed + " litres");
                    Console.WriteLine("Fuel left in tank: " + getFuel() + " litres");
                    Console.WriteLine("Total cost of journey: " + totalCost());
                }
            } else Console.WriteLine("not enough fuel for this trip");
        }
    }
}
 