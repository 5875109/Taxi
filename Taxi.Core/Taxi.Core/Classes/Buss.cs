using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Core.Interfases;

namespace Taxi.Core.Classes
{
    public class Buss : ICar
    {
        private string _carModel;
        private float _consumptionAuto;
        private float _priceAuto;
        private byte _speed;

        public void Buss(string carModel, float consumptionAuto, float prisceAuto, byte speed)
        {
         _carModel = carModel;
         _consumptionAuto = consumptionAuto;
         _priceAuto= prisceAuto;
         _speed = speed;

        }
        public string CarModel
        {
            get
            {
                return _carModel;
            }
            set
            {
                _carModel = value;
            }
        }

        public float ConsumptionAuto
        {
            get
            {
                return _consumptionAuto;
            }
            set
            {
                _consumptionAuto = value; 
            }
        }

        public float PriceAuto
        {
            get
            {
                return _priceAuto;
            }
            set
            {
                _priceAuto = value; 
            }
        }

        public byte Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }
    }
}
