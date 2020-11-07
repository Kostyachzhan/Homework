using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_world
{
    class Continent
    {
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

        public ref double GetFood(ref double NumberFood )
        {
            return ref NumberFood;
        }

        public void Display()
        {
            Console.WriteLine($"Name of continent={Name}, Food={Food}");
        }

        
    }
}