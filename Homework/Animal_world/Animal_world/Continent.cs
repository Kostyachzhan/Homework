using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_world
{
    class Continent
    {
        List<Harbivore> herbivore = new List<Harbivore>();
        List<Predator> predator = new List<Predator>();
        public string Name { get; set; }
        public double Food { get; set; }

        public Continent()
        {
        }

        public Continent(string continentName, int food)
        {
            this.Name = continentName;
            this.Food = food;
        }
        public void deleteHerbivore()
        {
            var toDelete = herbivore.Where(h => h.HitPoints <= 0).ToList();

            foreach (var td in toDelete) 
            {
                herbivore.Remove(td); 
            }
        }

        public void repoduceHerbivore() 
        {
            var toRepoduce = herbivore.Where(h => h.HitPoints > 150 && h.Satiety > 150).ToList();

            foreach(var tr in toRepoduce)
            {
                herbivore.Add(tr);
            }
        }

        public void deletePredator()
        {
            var toDelete = predator.Where(p => p.HitPoints <= 0).ToList();

            foreach (var td in toDelete)
            {
                predator.Remove(td);
            }
        }

        public void repoducePredator()
        {
            var toRepoduce = predator.Where(p => p.HitPoints > 150 && p.Satiety > 150).ToList();

            foreach (var tr in toRepoduce)
            {
                predator.Add(tr);
            }
        }

        public void Display()
        {
            Console.WriteLine($"Name of continent={Name}, Food={Food}");
        }

        
    }
}