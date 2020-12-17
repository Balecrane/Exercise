using System;

namespace _4
{

    public interface IVehicle
    {
        void Drive();
        void Park();
    }

    public class BmwCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving into the bus stop");
        }

        public void Park()
        {
            Console.WriteLine("Parking on as many parking spots as possible at the same time");
        }
    }

    public class AnyOtherCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving to the destination");
        }
        public void Park()
        {
            Console.WriteLine("Parking on a single parking spot");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bmw = new BmwCar();
            bmw.Drive();
            bmw.Park();
            var otherCar = new AnyOtherCar();
            otherCar.Park();
            otherCar.Drive();
        }
    }
}
