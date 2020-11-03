using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_world
{
    class Predator:Animal
    {
        public double Attack { get; set; }
        public Predator() : base()
        {
        }
        public Predator(string name, double attack) : base()
        {
            this.Attack = attack;
        }
        public override void Display()
        {
            Console.WriteLine($"Name={Name}: Species={Species}: Satiety={Satiety}: HP={HitPoints}: Attack={Attack}");
        }
    }
}
