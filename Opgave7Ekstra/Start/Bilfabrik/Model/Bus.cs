using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilfabrik.Model.Steering;

namespace Bilfabrik.Model
{
    class Bus : Car
    {
        public Bus(string brand, int numberOfSeats, int numberOfWheels, ColorType color, /*CarType type, */ ISteering steering)
            : base(brand, numberOfSeats, numberOfWheels, color, CarType.Bus, steering)
        { }

        public override string TextAboutWheels
            => "Der skal være 4 eller 6 hjul";

        public override string TextAboutSeats
            => "Der skal være mellem 9-30 sæder";

        public override bool SeatsIsAllowed()
            => (9 <= NumberOfSeats && NumberOfSeats <= 30);

        public override bool WheelsIsAllowed()
            => (4 == NumberOfWheels || NumberOfWheels == 6);
    }
}
