using Bilfabrik.Model.Steering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilfabrik.Model
{
    abstract class Car
    {
        public static Car CreateCar(CarType type, string brand, int numberOfSeats, int numberOfWheels, ColorType color, SteeringType steeringType)
        {
            Car carToReturn = null;

            SteeringWheel steering = null;
            // Hvilken styring skal bruges 
            // - fra start er der kun rattet!
            switch (steeringType)
            {
                case SteeringType.SteeringWheel:
                    steering = new SteeringWheel();
                    break;
                default:
                    steering = new SteeringWheel();
                    break;
            }

            // Hvilken biltype
            // - Fra start har vi kun Car

            switch (type)
            {
                case CarType.Personal:
                    carToReturn = new Personal(brand, numberOfSeats, numberOfWheels, color, steering);
                    break;
                case CarType.SUV:
                    carToReturn = new SUV(brand, numberOfSeats, numberOfWheels, color, steering);
                    break;
                case CarType.Van:
                    carToReturn = new Van(brand, numberOfSeats, numberOfWheels, color, steering);
                    break;
                case CarType.Truck:
                    carToReturn = new Truck(brand, numberOfSeats, numberOfWheels, color, steering);
                    break;
                default:
                    carToReturn = new Personal(brand, numberOfSeats, numberOfWheels, color, steering);
                    break;
            }

            

            return carToReturn;
        }

        public Car(string brand, int numberOfSeats, int numberOfWheels, ColorType color, CarType type, SteeringWheel steering)
        {
            Brand = brand;
            NumberOfSeats = numberOfSeats;
            NumberOfWheels = numberOfWheels;
            Color = color;
            Type = type;

            Steering = steering;
        }

        public string Brand { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public ColorType Color { get; set; }
        public CarType Type { get; set; }

        public SteeringWheel Steering { get; set; }

        public override string ToString()
        {
            var text = string.Format("{0} {1} {2}, styret af {3}, med {4} sæder og {5} hjul.", Color, Brand, Type, Steering, NumberOfSeats, NumberOfWheels);
            return text;
        }

        public abstract bool WheelsIsAllowed(int numberOfWheels);

        public abstract string TextAboutWheels { get; }

        public abstract bool SeatsIsAllowed(int numberOfSeats);

        public abstract string TextAboutSeats { get; }
            

    }
}
