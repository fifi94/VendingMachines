using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Ingredients
{
    // Concrete class representing Sugar ingredient
    public class Sugar : Ingredient
    {
        public Sugar(string name, double pricePerDose, double dose) : base(name, pricePerDose, dose) { }
    }
}
