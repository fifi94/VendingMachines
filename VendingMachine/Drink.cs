using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{

    public class Drink<TRecipe, TIngredient> where TRecipe : Recipe<TIngredient> where TIngredient : Ingredient
    {
        private readonly TRecipe recipe;
        private readonly decimal profitMargin;

        // Constructor for Drink with parameters for recipe and profit margin
        public Drink(TRecipe recipe, decimal profitMargin)
        {
            this.recipe = recipe ?? throw new ArgumentNullException(nameof(recipe), "Recipe cannot be null.");

            if (profitMargin <= 0)
                throw new ArgumentException("Profit margin must be greater than zero.", nameof(profitMargin));

            this.profitMargin = profitMargin;
        }

        // Method to calculate the cost of the drink
        public decimal CalculateCost()
        {
            decimal totalCost = recipe.GetIngredients().Sum(ingredient => ingredient.PricePerDose * ingredient.Dose);
            return totalCost * profitMargin;
        }
    }
}