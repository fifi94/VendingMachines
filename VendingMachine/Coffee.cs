using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // Concrete class representing Coffee ingredient
    public class Coffee : Ingredient
    {
        public Coffee(string name, decimal pricePerDose, decimal dose) : base(name, pricePerDose, dose) { }
    }

}
