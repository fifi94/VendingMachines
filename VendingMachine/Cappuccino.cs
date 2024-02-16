using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // Concrete class representing Cappuccino recipe

    public class Cappuccino<TIngredient> : Recipe<TIngredient> where TIngredient : Ingredient
    {
        public Cappuccino(TIngredient coffee, TIngredient chocolate, TIngredient water, TIngredient cream)
            : base("Cappuccino", new List<TIngredient> { coffee, chocolate, water, cream }) { }
    }

}
