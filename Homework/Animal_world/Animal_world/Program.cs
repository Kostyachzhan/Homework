using System;
using System.Collections.Generic;

namespace Animal_world
{/*
У нас есть различные континенты, содержащие такие параметры как количество еды для травоядных.
У нас есть травоядные и хищники.Оба класса имеет такие параметры как жизнь, сытость и (защита у травоядных, атака у хищников).

Метод питания у травоядных принимает в себя количество еды континента и уменьшает ее соответственно(использовать Рандом),
затем повышается сытость.Если сытость<1 - уменьшаем жизнь и защиту на рандомное маленькое число.

У хищников метод питания принимает травоядное и если атака у хищника больше чем защита у травоядного - он успешно питается 
(повышаем сытость у хищника, уменьшаем жизнь до 0 у травоядного).

Если нет - снижаем сытость хищника на рандомное число.
Если сытость<1 - уменьшаем жизнь и атаку на рандомное маленькое число.
Когда жизнь животного = 0 - удаляем из массива животных.
Если сытость животного и жизнь> 150 - он размножается.

При запуске программы - создаем континенты и животных на этих континентах.На каждом континенте - свои виды животных.
Затем создаем цикл в котором сперва питаются травоядные, затем хищники, и в конце снова рандомно устанавливаем количество
еды для травоядных у континента. На экран выводим статистическую информацию о животных и континентах (придумать самому какой
должна быть эта информация)
*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Continent c1 = new Continent("Europe",100);
            c1.Display();

            Harbivore h1 = new Harbivore();
            h1.Name = "Rabbit";
            h1.Species = "White";
            h1.HitPoints = 100;
            ///h1.Satiety = 100;
            h1.Defense = 20;
            ///h1.Display();


            Predator p1 = new Predator();
            p1.Name = "Lion";
            p1.Species = "Big";
            p1.HitPoints = 70;
            p1.Satiety = 60;
            p1.Attack = 80;
            ///p1.Display();



            ///h1.Nutrition();
            h1.Display();
            p1.Display();*/

            List<Continent> c1 = new List<Continent>();
            List<Harbivore> h1= new List<Harbivore>();
            List<Predator> p1 = new List<Predator>();

            с1.Add(new Continent() { Name = "Europe", Food = 100 });
            ///с2.Add(new Continent() { Name = "Africa", Food = 80 });

            h1.Add(new Harbivore() { Name = "Rabbit", Species = "white", HitPoints=80, Defense=10, Satiety=15 });
            h1.Add(new Harbivore() { Name = "Deer", Species = "big", HitPoints = 150, Defense = 20, Satiety = 5 });

            p1.Add(new Predator() { Name = "Wolf", Species = "black", HitPoints = 130, Attack = 70, Satiety = 10 });
            p1.Add(new Predator() { Name = "Lion", Species = "wh", HitPoints = 170, Attack = 100, Satiety = 15 });


            foreach (Harbivore h in h1)
            {
                Console.WriteLine(h.Name);
            }

            foreach (Predator p in p1)
            {
                Console.WriteLine(p.Name);
            }
            Console.ReadLine();
        }
    }
}