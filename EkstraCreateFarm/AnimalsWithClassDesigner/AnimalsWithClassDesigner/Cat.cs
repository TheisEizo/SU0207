using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsWithClassDesigner 
{
    public class Cat : Animal
    {
        public Cat(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
    }
}