using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_world
{
    public abstract class Animal
    {

        public string Name { get; set; }
        public string Species { get; set; }
        public double HitPoints { get; set; }
        public double Satiety { get; set; }

        public Animal() { }
        public Animal(string animalName, string species, double hp, double satiety)
        {
            this.Name = animalName;
            this.Species = species;
            this.HitPoints = hp;
            this.Satiety = satiety;
        }
        public abstract void Display();


    }
}