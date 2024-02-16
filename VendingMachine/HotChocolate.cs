using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // Concrete class representing Chocolat recipe
    public class HotChocolate<TIngredient> : Recipe<TIngredient> where TIngredient : Ingredient
    {
        public HotChocolate(TIngredient chocolate, TIngredient milk, TIngredient water, TIngredient sugar)
            : base("Hot Chocolate", new List<TIngredient> { chocolate, milk, water, sugar }) { }
    }

}
