using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Core;
using Taxi.Core.Interfases;

namespace Taxi.Core.Classes
{
    class Cars
    {
        private ICollection<Interfases.ICar> _Car;

        public Cars(ICollection<ICar> Car)
        {
            _Car=Car;
        }

        public void Add(Interfases.ICar Car)
        {
            _Car.Add(Car);
         }



        }

    }
       

