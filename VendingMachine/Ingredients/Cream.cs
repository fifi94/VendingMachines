using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Ingredients
{
    // Concrete class representing Cream ingredient
    public class Cream : Ingredient
    {
        public Cream(string name, double pricePerDose, double dose) : base(name, pricePerDose, dose) { }
    }
}
