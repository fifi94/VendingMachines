using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{

    // Generic class representing a recipe
   public class Recipe<TIngredient> where TIngredient : Ingredient
    {
        public string Name { get; }
        private readonly List<TIngredient> ingredients;

        // Constructor for Recipe with a parameter for ingredients
        public Recipe(string name, List<TIngredient> ingredients)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));

            if (ingredients == null || !ingredients.Any())
                throw new ArgumentException("Recipe must have at least one ingredient.", nameof(ingredients));

            Name = name;
            this.ingredients = ingredients;
        }

        // Method to get ingredients for the recipe
        public List<TIngredient> GetIngredients()
        {
            return new List<TIngredient>(ingredients);
        }
    }

}