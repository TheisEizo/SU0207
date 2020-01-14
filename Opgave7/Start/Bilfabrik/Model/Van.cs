using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilfabrik.Model.Steering;

namespace Bilfabrik.Model
{
    class Van : Car
    {
        public Van(string brand, int numberOfSeats, int numberOfWheels, ColorType color, /*CarType type, */ SteeringWheel steering) : base(brand, numberOfSeats, numberOfWheels, color, CarType.Van, steering)
        {
        }

        public override string TextAboutWheels => "Der skal være mellem 2-3 sæder";

        public override string TextAboutSeats => "Der skal være mellem 4-6 hjul, men et lige tal";

        public override bool SeatsIsAllowed(int numberOfSeats)
        {
            if (2 <= numberOfSeats && numberOfSeats <= 3)
                return true;
            else
                return false;
        }

        public override bool WheelsIsAllowed(int numberOfWheels)
        {
            if (2 <= numberOfWheels && numberOfWheels <= 6 && numberOfWheels%2==0)
                return true;
            else
                return false;
        }
    }
}
