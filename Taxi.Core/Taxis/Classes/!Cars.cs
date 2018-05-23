using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi.Core.Classes
{
   public class Cars 
    {
        public Guid _id { get; set; }
        public String _carModel { get; set; }
        public float _consumptionAuto { get; set; }
        public float _priceAuto { get; set; }

    }
}
