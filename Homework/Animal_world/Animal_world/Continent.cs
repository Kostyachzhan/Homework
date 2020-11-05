using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_world
{
    class Continent
    {
        Random rnd = new Random();
        public int Food { get; set; }

        public Continent(int food)
        {
            this.Food = food;
        }
        public void Display()
        {
            Console.WriteLine($"Food={Food}");
        }
    }
}