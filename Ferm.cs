using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferm
{
    internal class Ferm
    {
        protected List<Building> buildings;
        protected ILogger Logger { get; private set; }


        public Ferm(ILogger logger) {
            Logger = logger;
        }
    }
}
