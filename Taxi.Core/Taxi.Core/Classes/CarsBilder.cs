using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Core.Interfases;

namespace Taxi.Core.Classes
{
    class CarsBilder
    {
        private Cars _cars;

        public CarsBilder(ICollection<Interfases.ICar> cars)
        {
            _cars = (ICollection<Interfases.ICar>)cars;
        }
    }
}
