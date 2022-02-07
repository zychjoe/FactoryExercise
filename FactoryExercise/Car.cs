using System;
namespace FactoryExercise 
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("A Car is Born!");
        }

        public void Drive()
        {
            Console.WriteLine("This Car drives!");
        }
    }
}
