using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_world
{
    class Continent
    {
        public List<Harbivore> Herbivores { get; set; } = new List<Harbivore>();
        public List<Predator> Predators { get; set; } = new List<Predator>();
        public string Name { get; set; }
        public double Food { get; set; }

        public Continent() { }

        public Continent(string continentName, int food)
        {
            this.Name = continentName;
            this.Food = food;
        }

        public void deleteHerbivore()
        {
            var toDelete = Herbivores.Where(h => h.HitPoints <= 0).ToList();

            foreach (var td in toDelete)
            {
                Herbivores.Remove(td);
            }
        }

        public void reproduceHerbivore()
        {
            var toRepoduce = Herbivores.Where(h => h.HitPoints > 150 && h.Satiety > 150).ToList();

            foreach (var tr in toRepoduce)
            {
                Herbivores.Add(tr);
            }
        }

        public void deletePredator()
        {
            var toDelete = Predators.Where(p => p.HitPoints <= 0).ToList();

            foreach (var td in toDelete)
            {
                Predators.Remove(td);
            }
        }

        public void reproducePredator()
        {
            var toRepoduce = Predators.Where(p => p.HitPoints > 150 && p.Satiety > 150).ToList();

            foreach (var tr in toRepoduce)
            {
                Predators.Add(tr);
            }
        }


        public void Fedding()
        {
            foreach (Harbivore h in Herbivores)
            {
                h.nutritionHerb(Food);
                Console.WriteLine($"Name={h.Name}, Species={h.Species}, Satiety={h.Satiety}, HP={h.HitPoints}, Defense={h.Defense}");
            }
            foreach (Predator p in Predators)
            {
                p.nutritionPred(Herbivores);
                Console.WriteLine($"Name={p.Name}: Species={p.Species}: Satiety={p.Satiety}: HP={p.HitPoints}: Attack={p.Attack}");
            }
            reproduceHerbivore();
            deleteHerbivore();
            reproducePredator();
            deletePredator();
        }

        public void ShowAnimals()
        {
            foreach (var h in Herbivores)
            {
                Console.WriteLine($"Name={h.Name}, Species={h.Species}, Satiety={h.Satiety}, HP={h.HitPoints}, Defense={h.Defense}");
            }
            foreach (var p in Predators)
            {
                Console.WriteLine($"Name={p.Name}: Species={p.Species}: Satiety={p.Satiety}: HP={p.HitPoints}: Attack={p.Attack}");
            }
        }


        public void Display()
        {
            Console.WriteLine($"Name of continent={Name}, Food={Food}");
        }


    }
}