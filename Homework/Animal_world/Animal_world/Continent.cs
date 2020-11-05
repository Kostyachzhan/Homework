using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_world
{
    class Continent
    {
        Random rnd = new Random();
        public string Name { get; set; }
        public double Food { get; set; }

        public Continent()
        {
        }
        public Continent(string continentName, int food)
        {
            this.Name = continentName;
            this.Food = food;
        }
        public void Display()
        {
            Console.WriteLine($"Name of continent={Name}, Food={Food}");
        }

        
    }
}