using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWithClassDesigner
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow cow1 = new Cow();
            cow1.Name = "Moose";
            cow1.Sound = "Muuh";

            Dog dog1 = new Dog("Pluto");
            dog1.Sound = "Woof";

            Cat cat1 = new Cat("Figaro", "Miav");

            Farm farm = new Farm();

            farm.Animals.Add(cow1);
            farm.Animals.Add(dog1);
            farm.Animals.Add(cat1);

            farm.HearAllTheAnimalsSound();
            Console.ReadKey();
        }
    }
}
