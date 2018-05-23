using System.Collections.Generic;
using Taxi.Core.Interfases;

namespace Taxi.Core.Classes
{
   public class TaxisBilder
    {
        private ICollection<ICar> _cars;

        public float TaxisCost(ICollection<ICar> cars)
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
