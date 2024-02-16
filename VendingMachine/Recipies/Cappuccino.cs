using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Ingredients;

namespace VendingMachine.Recipies
{
    // Concrete class representing Cappuccino recipe

    public class Cappuccino<TIngredient> : Recipe<TIngredient> where TIngredient : Ingredient
    {
        public Cappuccino(TIngredient coffee, TIngredient chocolate, TIngredient water, TIngredient cream)
            : base("Cappuccino", new List<TIngredient> { coffee, chocolate, water, cream }) {
            ValidateIngredients();


        }


        private void ValidateIngredients()
        {
            foreach (var ingredient in GetIngredients())
            {
                if (!(ingredient is Coffee) && !(ingredient is Chocolate) && !(ingredient is Water)&&!(ingredient is Cream))
                {
                    throw new ArgumentException("The ingredients of Cappuccino are incorrect.");
                }
            }
        }

    }

}
