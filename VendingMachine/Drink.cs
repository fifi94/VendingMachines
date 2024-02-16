using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Ingredients;
using VendingMachine.Recipies;

namespace VendingMachine
{

    public class Drink<TRecipe, TIngredient> where TRecipe : Recipe<TIngredient> where TIngredient : Ingredient
    {
        private readonly TRecipe recipe;
        private readonly double profitMargin;

        // Constructor for Drink with parameters for recipe and profit margin
        public Drink(TRecipe recipe, double profitMargin)
        {
            this.recipe = recipe ?? throw new ArgumentNullException(nameof(recipe), "Recipe cannot be null.");

            if (profitMargin <= 0)
                throw new ArgumentException("Profit margin must be greater than zero.", nameof(profitMargin));

            ValidateIngredients();

            this.profitMargin = profitMargin;
        }

     

        // Method to calculate the cost of the drink
        public double CalculateCost()
        {
            double totalCost = recipe.GetIngredients().Sum(ingredient => ingredient.PricePerDose * ingredient.Dose);
            return totalCost * profitMargin;
        }
        private void ValidateIngredients()
        {
            foreach (var ingredient in recipe.GetIngredients())
            {
                ingredient.ValidateDose();
                ingredient.ValidatePrice();
            }
        }
    }
}