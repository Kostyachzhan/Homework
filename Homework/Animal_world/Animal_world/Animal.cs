using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_world
{
    public abstract class Animal
    {

        public string Name { get; set; }
        public string Species { get; set; }

        public Animal() { }
        public Animal(string animalName, string species)
        {
            this.Name = animalName;
            this.Species = species;
        }
        public abstract void Remove(object obj);
        public abstract void Display();


    }
}