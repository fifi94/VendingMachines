using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Ingredients
{
    // Concrete class representing Coffee ingredient
    public class Coffee : Ingredient
    {
        public Coffee(string name, double pricePerDose, double dose) : base(name, pricePerDose, dose) { }
    }

}
