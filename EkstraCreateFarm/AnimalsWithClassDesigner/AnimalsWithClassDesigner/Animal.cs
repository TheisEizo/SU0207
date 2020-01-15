using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsWithClassDesigner
{
    public abstract class Animal
    {
        private string _sound;
        private string _name;

        public string Sound
        {
            get { return _sound; }
            set { _sound = value; }
        } 

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void MakeSound()
        {
            Console.WriteLine($"I am {_name} and I say {_sound}");
        }
    }
}