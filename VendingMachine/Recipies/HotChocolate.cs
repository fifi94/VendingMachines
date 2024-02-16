using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Ingredients;

namespace VendingMachine.Recipies
{
    // Concrete class representing Chocolat recipe
    public class HotChocolate<TIngredient> : Recipe<TIngredient> where TIngredient : Ingredient
    {
        public HotChocolate(TIngredient chocolate, TIngredient milk, TIngredient water, TIngredient sugar)
            : base("Hot Chocolate", new List<TIngredient> { chocolate, milk, water, sugar })
        {
            ValidateIngredients();


        }


        private void ValidateIngredients()
        {
            foreach (var ingredient in GetIngredients())
            {
                if ( !(ingredient is Chocolate) && !(ingredient is Water) && !(ingredient is Milk) && !(ingredient is Sugar))
                {
                    throw new ArgumentException("The ingredients of Hot Chocolate are incorrect.");
                }
            }
        }


    }

}
