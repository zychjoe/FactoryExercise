using System;

namespace FactoryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want 2 or 4 tires on your vehicle?");
            VehicleFactory.GetVehicle(Console.ReadLine());
        }
    }
}
