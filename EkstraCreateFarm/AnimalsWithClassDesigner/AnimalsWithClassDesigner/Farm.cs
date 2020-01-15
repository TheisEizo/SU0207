using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalsWithClassDesigner
{
    public class Farm
    {
        private List<Animal> _animals = new List<Animal>();

        public List<Animal> Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }

        public void HearAllTheAnimalsSound()
        {
            foreach (var animal in _animals)
            {
                animal.MakeSound();
            }
        }
    }
}