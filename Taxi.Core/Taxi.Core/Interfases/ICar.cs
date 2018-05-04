using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi.Core.Interface
{
    public interface ICar: IConsumptionAuto, IPriceAuto, ISpeeddAuto
    {
       string NameAuto {get; set;}
    }
}
