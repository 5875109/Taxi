﻿using System.Collections.Generic;
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

        return _cars;
        }

        public ICollection<ICar> RangeSpeed(byte from, byte to)
        {
            return _cars;
        }
        public void TaxisBilder(ICollection<ICar> taxis)
        {
            _cars = taxis;
        }
    }
}
