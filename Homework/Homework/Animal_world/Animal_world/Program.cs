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

            List<Continent> c1 = new List<Continent>();
            c1.Add(new Continent() { Name = "Europe" });
            c1[0].Herbivores.Add(new Harbivore() { Name = "Rabbit", Species = "white", HitPoints = 190, Defense = 100, Satiety = 170 });
            c1[0].Herbivores.Add(new Harbivore() { Name = "Deer", Species = "big", HitPoints = 150, Defense = 20, Satiety = 5 });
            c1[0].Predators.Add(new Predator() { Name = "Wolf", Species = "black", HitPoints = 130, Attack = 70, Satiety = -10 });
            c1[0].Predators.Add(new Predator() { Name = "Bear", Species = "wh", HitPoints = 170, Attack = 100, Satiety = -10 });

            c1[0].Fedding();
            Console.WriteLine($"\n");
            c1[0].Display();
            Console.WriteLine($"________________________________________________________\n");
            c1[0].ShowAnimals();

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------\n");
            Console.WriteLine("\n");

            List<Continent> c2 = new List<Continent>();
            c2.Add(new Continent() { Name = "Africa", Food = 80 });
            c2[0].Herbivores.Add(new Harbivore() { Name = "Elephant", Species = "white", HitPoints = 120, Defense = 100, Satiety = -10 });
            c2[0].Herbivores.Add(new Harbivore() { Name = "Giraffe", Species = "big", HitPoints = 150, Defense = 50, Satiety = -10 });
            c2[0].Predators.Add(new Predator() { Name = "Lion", Species = "black", HitPoints = 160, Attack = 70, Satiety = 60 });
            c2[0].Predators.Add(new Predator() { Name = "Cheetah", Species = "wh", HitPoints = 170, Attack = 100, Satiety = 180 });

            c2[0].Fedding();
            Console.WriteLine($"\n");
            c2[0].Display();
            Console.WriteLine($"________________________________________________________\n");
            c2[0].ShowAnimals();

            Console.ReadLine();
        }
    }
}