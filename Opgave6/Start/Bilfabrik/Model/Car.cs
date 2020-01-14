using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilfabrik.Model
{
    class Car
    {
        //Fields

        //Properties
        public string Brand { get; set; }
        public int NumberOfSeats { get; set; }
        private int NumberOfWheels { get; set; }
        private ColorType Color { get; set; }
        private CarType Type { get; set; }

        //Methods
        public override string ToString()
            => $"{Color} {Brand} {Type}, med {NumberOfSeats} sæder og {NumberOfWheels} hjul.";

        public Car(string brand, int numberOfSeats, int numberOfWheels, ColorType color, CarType type)
        {
            Brand = brand;
            NumberOfSeats = numberOfSeats;
            NumberOfWheels = numberOfWheels;
            Color = color;
            Type = type;
        }

        //Events

    }
}
