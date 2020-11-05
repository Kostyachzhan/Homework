using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_world
{
    class Harbivore : Animal
    {
        public double Defense { get; set; }
        public Harbivore() : base()
        {
        }
        public Harbivore(string name, double defense) : base()
        {
            this.Defense = defense;
        }

        public override void Display()
        {
            Console.WriteLine($"Name={Name}: Species={Species}: Satiety={Satiety}: HP={HitPoints}: Defense={Defense}");
        }
    }
}