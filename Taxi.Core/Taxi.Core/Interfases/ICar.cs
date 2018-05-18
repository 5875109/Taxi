using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Core.Interface;



namespace Taxi.Core.Interfases
{
    public interface Interfases
    {
    }
    public interface ICar : IConsumptionAuto, IPriceAuto, ISpeeddAuto
    {
        
        string CarModel { get; }
        void add();
    }
}
