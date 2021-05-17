using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceIntroduction
{
    interface IVehicle
    {
        public void ModeOfTransport();
        public void Brand(string brand);
        public void SeatingCapacity(int numberOfSeats);
        public void Speed();

    }
}
