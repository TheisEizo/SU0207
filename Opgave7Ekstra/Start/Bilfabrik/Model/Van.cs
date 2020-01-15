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
        public Van(string brand, int numberOfSeats, int numberOfWheels, ColorType color, /*CarType type, */ ISteering steering)
            : base(brand, numberOfSeats, numberOfWheels, color, CarType.Van, steering)
        {}

        public override string TextAboutWheels
            => "Der skal være mellem 4-6 hjul, men et lige tal";

        public override string TextAboutSeats
            => "Der skal være mellem 2-3 sæder";

        public override bool SeatsIsAllowed()
            => (2 <= NumberOfSeats && NumberOfSeats <= 3);

        public override bool WheelsIsAllowed()
            => (2 <= NumberOfWheels && NumberOfWheels <= 6 && NumberOfWheels % 2 == 0); 
    }
}