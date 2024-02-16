using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Ingredients
{
    // Concrete class representing Choclate ingredient
    public class Milk : Ingredient
    {
        public Milk(string name, double pricePerDose, double dose) : base(name, pricePerDose, dose)
        {
        }
    }
}
