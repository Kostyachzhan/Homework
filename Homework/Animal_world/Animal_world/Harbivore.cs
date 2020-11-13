using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Animal_world
{
    /* Метод питания у травоядных принимает в себя количество еды континента и уменьшает ее соответственно(использовать Рандом),
    затем повышается сытость.Если сытость<1 - уменьшаем жизнь и защиту на рандомное маленькое число.*/
    class Harbivore : Animal
    {
        Random rnd = new Random();

        public double HitPoints { get; set; }
        public double Satiety { get; set; } = 10;
        public double Defense { get; set; }
        public Harbivore() : base()
        {
        }
        public Harbivore(string name, double defense, double hp, double satiety) : base()
        {
            this.Defense = defense;
            this.HitPoints = hp;
            this.Satiety = satiety;
        }

        public void nutritionHerb(double food)
        {
            var t = 0;
            t += rnd.Next(0, 5);
            Satiety += t;
            food -= t;
            if (Satiety < 1)
            {
                HitPoints -= rnd.Next(1, 10);
                Defense -= rnd.Next(1, 10);
            }
        }

        public override void Display()
        {
            Console.WriteLine($"Name={Name}: Species={Species}: Satiety={Satiety}: HP={HitPoints}: Defense={Defense}");
        }

    }
}