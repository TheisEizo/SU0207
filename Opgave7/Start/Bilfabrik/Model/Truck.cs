using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bilfabrik.Model.Steering;

namespace Bilfabrik.Model
{
    class Truck : Car
    {
        public Truck(string brand, int numberOfSeats, int numberOfWheels, ColorType color, /*CarType type, */ ISteering steering) 
            : base(brand, numberOfSeats, numberOfWheels, color, CarType.Truck, steering)
        {}

        public override string TextAboutWheels 
            => "Der skal være mellem 4-10 hjul, men et lige tal";

        public override string TextAboutSeats 
            => "Der skal være mellem 2-3 sæder";

        public override bool SeatsIsAllowed(int numberOfSeats)
            => (2 <= numberOfSeats && numberOfSeats <= 3);

        public override bool WheelsIsAllowed(int numberOfWheels)
        => (4 <= numberOfWheels && numberOfWheels <= 10 && numberOfWheels % 2 == 0);  
    }
}
