using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Ingredients
{
    // Concrete class representing Water ingredient
    public class Water : Ingredient
    {
        public Water(string name, double pricePerDose, double dose) : base(name, pricePerDose, dose) { }
    }

}
