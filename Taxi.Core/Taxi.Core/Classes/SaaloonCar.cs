using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Core;
using Taxi.Core.Interfases;

namespace Taxi.Core.Classes
{
    class SaaloonCar : Interfases.ICar
    {
        Interfases.ICar _Car;

        private void Id
        {
            _Car.Guid = new Guid();

        }

        string ICar.CarModel
        {
            get { throw new NotImplementedException(); }
        }

        float Interface.IConsumptionAuto.ConsumptionAuto
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float Interface.IPriceAuto.PriceAuto
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        byte Interface.ISpeeddAuto.Speed
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

       
}
