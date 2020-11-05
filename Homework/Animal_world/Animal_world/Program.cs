using System;

namespace Animal_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Harbivore h = new Harbivore();
            h.Name = "Rabbit";
            h.Species = "White";
            h.HitPoints = 100;
            h.Satiety = 100;
            h.Defense = 20;
            h.Display();


            Predator p = new Predator();
            p.Name = "Lion";
            p.Species = "Big";
            p.HitPoints = 70;
            p.Satiety = 60;
            p.Attack = 80;
            p.Display();

        }
    }
}