using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Ingredients;
using VendingMachine.Recipies;

namespace VendingMachine.Drinks
{

    // Concrete class representing Espresso recipe
    public class Espresso<TIngredient> : Recipe<TIngredient> where TIngredient : Ingredient
    {
        public Espresso(TIngredient coffee, TIngredient water)
            : base("Espresso", new List<TIngredient> { coffee, water }) {
            ValidateIngredients();
        }

        private void ValidateIngredients()
        {
            foreach (var ingredient in GetIngredients())
            {
                if (!(ingredient is Coffee) && !(ingredient is Water))
                {
                    throw new ArgumentException("The ingredients of Espresso are incorrect.");
                }
            }
        }


    }

}
