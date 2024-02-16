using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Ingredients;

namespace VendingMachine.Recipies
{

    // Concrete class representing The recipe
    public class TeaDrink<TIngredient> : Recipe<TIngredient> where TIngredient : Ingredient
    {
        public TeaDrink(TIngredient tea, TIngredient water)
            : base("Tea", new List<TIngredient> { tea, water }) {
            ValidateIngredients();


        }


        private void ValidateIngredients()
        {
            foreach (var ingredient in GetIngredients())
            {
                if (!(ingredient is Tea) && !(ingredient is Water))
                {
                    throw new ArgumentException("The ingredients of Tea are incorrect.");
                }
            }
        }

    }

}
