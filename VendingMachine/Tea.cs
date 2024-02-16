using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // Concrete class representing Tea ingredient
    public class Tea : Ingredient
    {
        public Tea(string name, decimal pricePerDose,decimal dose ) : base(name, pricePerDose,dose) { }
    }

}
