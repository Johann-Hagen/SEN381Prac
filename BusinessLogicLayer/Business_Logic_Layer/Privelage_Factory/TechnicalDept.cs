using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_PA1_Hagen_Johann.Business_Logic_Layer.Privelage_Factory
{
    class TechnicalDept : Department // class that will be used to grant access to the Technical Department form
    {
        public string returnPrivilage()
        {
            return "Technical";
        }
    }
}
