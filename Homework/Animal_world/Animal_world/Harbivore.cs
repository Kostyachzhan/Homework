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
        List<Animal> a = new List<Animal>();
        Random rnd = new Random();
        Continent c = new Continent();
        static double satiety=10;
        public double HitPoints { get; set; }
        public double Satiety { get; set; }
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

        public double Nutrition() 
        {
            if (satiety < 1)
            {
                HitPoints -= rnd.Next(0, 3);
                Defense -= rnd.Next(0, 5);
            }   
        }
        public void Repoduce(Animal a) 
        {
            if(Satiety>150 && HitPoints > 150) 
            {
                a.Add(new Harbivore);
            }

        }

        public override void Display()
        {
            Console.WriteLine($"Name={Name}: Species={Species}: Satiety={Satiety}: HP={HitPoints}: Defense={Defense}" + " Nutrition: " + Nutrition());
        }
    }
}