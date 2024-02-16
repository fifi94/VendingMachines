using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{

    // Concrete class representing Long Coffee recipe

    public class LongCoffee<TIngredient> : Recipe<TIngredient> where TIngredient : Ingredient
    {
        public LongCoffee(TIngredient coffee, TIngredient water)
            : base("Long Coffee", new List<TIngredient> { coffee, water }) { }
    }

}
