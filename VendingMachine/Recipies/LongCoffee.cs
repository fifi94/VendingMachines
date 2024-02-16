using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Ingredients;

namespace VendingMachine.Recipies
{

    // Concrete class representing Long Coffee recipe

    public class LongCoffee<TIngredient> : Recipe<TIngredient> where TIngredient : Ingredient
    {
        public LongCoffee(TIngredient coffee, TIngredient water)
            : base("Long Coffee", new List<TIngredient> { coffee, water }) {
            ValidateIngredients();


        }


        private void ValidateIngredients()
        {
            foreach (var ingredient in GetIngredients())
            {
                if (!(ingredient is Coffee) && !(ingredient is Water) )
                {
                    throw new ArgumentException("The ingredients of Long Coffee are incorrect.");
                }
            }
        }

    }

}
