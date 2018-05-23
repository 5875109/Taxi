using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Core;
using Taxi.Core.Interfases;

namespace Taxi.Core.Classes
{
    class Cars : Interfases.ICar
    {
        private Interfases.ICar _Car;

        public Cars(ICar Car)
        {
            _Car = Car;
        }

        Guid ICar.Id
        {
            get { throw new NotImplementedException(); }
        }

        string ICar.CarModel
        {
            get { throw new NotImplementedException(); }
        }

        void ICar.add()
        {
            throw new NotImplementedException();
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


