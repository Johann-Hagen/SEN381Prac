using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLogicLayer.Privelage_Factory
{
    interface Department // Interface that will constructs the concerete classes of the factory pattern
    {
        string returnPrivilage();
    }
}
