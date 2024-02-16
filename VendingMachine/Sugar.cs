using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // Concrete class representing Sugar ingredient
    public class Sugar : Ingredient
    {
        public Sugar(string name, decimal pricePerDose,decimal dose) : base(name, pricePerDose, dose) { }
    }
}
