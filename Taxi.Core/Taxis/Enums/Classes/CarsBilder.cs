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
        private ICollection<ICar> _cars;

        public CarsBilder(ICollection<Interfases.ICar> cars)
        {
           _cars = (ICollection<Interfases.ICar>)cars;
        }

        public void Add(ICar Car)
        {
            _cars.Add(Car);
        }

        public ICollection<ICar> GetCarList()
        {
            return _cars; 
        }


    }
}
