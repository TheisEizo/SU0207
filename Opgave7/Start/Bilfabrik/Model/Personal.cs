using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilfabrik.Model.Steering;

namespace Bilfabrik.Model
{
    class Personal : Car
    {
        public Personal(string brand, int numberOfSeats, int numberOfWheels, ColorType color, /*CarType type, */ SteeringWheel steering) : base(brand, numberOfSeats, numberOfWheels, color, CarType.Personal, steering)
        {
        }

        public override string TextAboutWheels => "Der skal være mellem 2-6 sæder";

        public override string TextAboutSeats => "Der skal være mellem 3-4 hjul";

        public override bool SeatsIsAllowed(int numberOfSeats)
        {
            if (2 <= numberOfSeats && numberOfSeats <= 6)
                return true;
            else
                return false;
        }

        public override bool WheelsIsAllowed(int numberOfWheels)
        {
            if (3 <= numberOfWheels && numberOfWheels <= 4)
                return true;
            else
                return false;
        }
    }
}
