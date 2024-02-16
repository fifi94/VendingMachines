using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // Concrete class representing Water ingredient
    public class Water : Ingredient
    {
        public Water(string name, decimal pricePerDose, decimal dose) : base(name, pricePerDose,dose) { }
    }

}
