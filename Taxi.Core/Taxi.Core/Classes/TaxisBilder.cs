using System.Collections.Generic;
using Taxi.Core.Interfases;

namespace Taxi.Core.Classes
{
    class TaxisBilder
    {
        private ICollection<ICar> _cars;

        public float TaxisCost()
        {
            return 10;
        }

        public ICollection<ICar> SorCarsByConsumptionAuto()
        {
   
            //return ICollection<ICar>;
        }

        public ICollection<ICar> RangeSpeed(byte from, byte to)
        {

        }
    }
}
