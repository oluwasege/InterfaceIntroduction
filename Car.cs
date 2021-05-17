using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIntroduction
{
    class Car : IVehicle
    {
       public string BrandName { get; set; }
        public int SeatNumbers { get; set; }
        public void Brand(string brand)
        {
            BrandName = brand;
            Console.WriteLine($"\nBrand nanme :\t{BrandName}");
        }


        public void ModeOfTransport()
        {
            Console.WriteLine($"\nMode of Transport :\tLand");
        }


        public void SeatingCapacity(int numberOfSeats)
        {
            SeatNumbers = numberOfSeats;
            Console.WriteLine($"\n{BrandName} has a {SeatNumbers} people Seating Capacity");
        }
        
       
        public void Speed()
        {
            Console.WriteLine("\nCan reach Speeds of up to 200MPH\n\n");
        }
    }
}
