using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_world
{
    /* У хищников метод питания принимает травоядное и если атака у хищника больше чем защита у травоядного - он успешно питается 
    (повышаем сытость у хищника, уменьшаем жизнь до 0 у травоядного).
    Если нет - снижаем сытость хищника на рандомное число.
    Если сытость<1 - уменьшаем жизнь и атаку на рандомное маленькое число.*/
    class Predator : Animal
    {
        Random rnd = new Random();
        Harbivore h = new Harbivore();
        static double satiety = 10;
        public double HitPoints { get; set; }
        public double Satiety { get; set; }
        public double Attack { get; set; }
        public Predator() : base()
        {
        }
        public Predator(string name, double attack) : base()
        {
            this.Attack = attack;
        }

       /* public double nutritionPred(ref double food) 
        {
            if (Attack > h.Defense)
            {
                h.HitPoints = 0;
                satiety += rnd.Next(0, 5);
            }
            else
            {
                satiety -= rnd.Next(0, 5);
                if (satiety < 1)
                {
                    HitPoints -= rnd.Next(0, 5);
                    Attack -= rnd.Next(0, 5);
                }
            }

        }*/

        public override void Display()
        {
            Console.WriteLine($"Name={Name}: Species={Species}: Satiety={Satiety}: HP={HitPoints}: Attack={Attack}");
        }

        public override void Remove(object obj)
        {
            throw new NotImplementedException();
        }
    }
}