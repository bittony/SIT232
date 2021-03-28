using System;

namespace Car
{
    class CarProgram
    {
        static void Main(string[] args)
        {
            Car newCar = new Car(25);

            Console.Write("Cost of fuel per litre: ");
            newCar.printFuelCost();
            
            Console.WriteLine("Please enter the amount of fuel to add to car in litres: ");
            newCar.addFuel(Convert.ToDouble(Console.ReadLine()));
            
            Console.WriteLine("Please enter the amount of fuel in litres to calculate the cost: ");
            newCar.calcCost(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Please enter the amount of fuel in gallons to convert to litres:  ");
            newCar.convertToLitres(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Please enter the total distance of the journey in miles:  ");
            newCar.drive(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Please enter the total distance of the journey in miles:  ");
            newCar.drive(Convert.ToDouble(Console.ReadLine()));
        }
    }
}
