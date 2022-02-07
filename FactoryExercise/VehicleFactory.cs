using System;
namespace FactoryExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string tires)
        {
            switch (tires)
            {
                case "2":
                    return new Motorcycle();
                case "4":
                    return new Car();
                default:
                    throw new Exception("Please pick 2 or 4");
            }

        }
    }
}
