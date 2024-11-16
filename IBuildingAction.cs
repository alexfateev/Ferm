using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferm
{
    internal interface IBuildingAction
    {
        public void AddAnimal(Animal animal);
        public bool RemoveAnimal(Animal animal);
        public void ClearFromDead();
    }
}
