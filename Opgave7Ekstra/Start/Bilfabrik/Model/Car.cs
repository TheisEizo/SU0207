using Bilfabrik.Model.Steering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilfabrik.Model
{
    abstract class Car : IComparable
    {
        public static Car CreateCar(CarType type, string brand, int numberOfSeats, int numberOfWheels, ColorType color, SteeringType steeringType)
        {
            Car carToReturn = null;

             ISteering steering = null;
            // Hvilken styring skal bruges 
            switch (steeringType)
            {
                case SteeringType.SteeringWheel:
                    steering = new SteeringWheel();
                    break;
                case SteeringType.Brain:
                    steering = new Brain();
                    break;
                case SteeringType.Joystick:
                    steering = new Joystick();
                    break;
                default:
                    throw new Exception("SteeringType ikke valgt korrekt");
            }

            // Hvilken biltype
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
                case CarType.Bus:
                    carToReturn = new Bus(brand, numberOfSeats, numberOfWheels, color, steering);
                    break;
                default:
                    throw new Exception("CarType ikke valgt korrekt");
            }

            return carToReturn;
        }

        public Car(string brand, int numberOfSeats, int numberOfWheels, ColorType color, CarType type, ISteering steering)
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

        public ISteering Steering { get; set; }

        public override string ToString()
            => $"{Color} {Brand} {Type}, styret af {Steering}, med {NumberOfSeats} sæder og {NumberOfWheels} hjul.";

        public abstract bool WheelsIsAllowed();

        public abstract string TextAboutWheels { get; }

        public abstract bool SeatsIsAllowed();

        public int CompareTo(object obj)
        {
            var car = (Car)obj;
            return NumberOfWheels.CompareTo(car.NumberOfWheels);
        }

        public abstract string TextAboutSeats { get; }
    }
}
