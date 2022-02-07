using System;
namespace FactoryExercise
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {
            Console.WriteLine("It's a bird -- it's a plane -- No, no! it's a Motorcycle!!! ");
        }

        public void Drive()
        {
            Console.WriteLine("This Motorcycle is flyin'!");
        }
    }
}
