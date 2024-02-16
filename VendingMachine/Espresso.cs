using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{

    // Concrete class representing Espresso recipe
    public class Espresso<TIngredient> : Recipe<TIngredient> where TIngredient : Ingredient
    {
        public Espresso(TIngredient coffee, TIngredient water)
            : base("Espresso", new List<TIngredient> { coffee, water }) { }
    }

}
