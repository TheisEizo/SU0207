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
        public Personal(string brand, int numberOfSeats, int numberOfWheels, ColorType color, /*CarType type, */ ISteering steering) 
            : base(brand, numberOfSeats, numberOfWheels, color, CarType.Personal, steering)
        {}

        public override string TextAboutWheels 
            => "Der skal være mellem 3-4 hjul";

        public override string TextAboutSeats 
            => "Der skal være mellem 2-6 sæder";

        public override bool SeatsIsAllowed()
            => (2 <= NumberOfSeats && NumberOfSeats <= 6);

        public override bool WheelsIsAllowed()
            => (3 <= NumberOfWheels && NumberOfWheels <= 4);
    }
}
