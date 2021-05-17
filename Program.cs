using System;

namespace InterfaceIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle myCar = new Car();
            myCar.Brand("Ford");
            myCar.SeatingCapacity(4);
            myCar.ModeOfTransport();
            myCar.Speed();
            IVehicle myboat = new Boat();
            myboat.Brand("Grand Dutchess");
            myboat.SeatingCapacity(14);
            myboat.ModeOfTransport();
            myboat.Speed();
        }
    }
}
