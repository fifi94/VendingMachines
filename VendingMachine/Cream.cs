using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // Concrete class representing Cream ingredient
   public class Cream : Ingredient
    {
        public Cream(string name, decimal pricePerDose,decimal dose ) : base(name, pricePerDose, dose) { }
    }
}
