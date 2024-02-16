using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{

    // Concrete class representing The recipe
    public class TeaDrink<TIngredient> : Recipe<TIngredient> where TIngredient : Ingredient
    {
        public TeaDrink(TIngredient tea, TIngredient water)
            : base("Tea", new List<TIngredient> { tea, water }) { }
    }

}
