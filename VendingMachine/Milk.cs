using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // Concrete class representing Choclate ingredient
    public class Milk:Ingredient
    {
        public Milk(string name, decimal pricePerDose, decimal dose) : base(name, pricePerDose, dose)
        {
        }
    }
}
