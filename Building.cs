using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferm
{
    internal abstract class Building : IBuildingAction
    {
        public List<Animal> Animals { get; private set; }
        protected string Name { get; private set; }
        protected int LimitAnimal { get; private set; }

        public delegate void BuildingHandler(string message);
        public event BuildingHandler? Notify;

        protected const int _limitAnimal = 4;

        protected abstract string TextAnimalAdd { get; }
        protected abstract string TextAnimalRemove { get; }
        protected abstract string TextAnimalDeadClear { get; }
        protected abstract string TextAnimalLimitExceed{ get; }

        public Building(string name, int limit = _limitAnimal)
        {
            Name = name;    
            LimitAnimal = limit;
            Animals = new List<Animal> { };
        }
        public void AddAnimal(Animal animal)
        {
            if (Animals.Count < LimitAnimal)
            {
                Animals.Add(animal);
                Notify?.Invoke($"{Name}: {TextAnimalAdd}");
            } else
            {
                Notify?.Invoke($"{Name}: {TextAnimalLimitExceed}");
            }
        }
        public bool RemoveAnimal(Animal animal)
        {
            var res = Animals.Remove(animal);
            if (res) Notify?.Invoke($"{Name}: {TextAnimalRemove}");
            return res;
        }

        public void ClearFromDead()
        {
            var res = Animals.RemoveAll(a => !a.IsAlive);
            Notify?.Invoke($"{Name}: {TextAnimalDeadClear}");
        }

    }
}
