// Add other recipe classes following the same pattern

using System.Diagnostics;
using VendingMachine;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello!");
        TestDrinkCostCalculation();
    
    }

    // Method to test the calculation of drink cost
    static void TestDrinkCostCalculation()
    {
        Coffee coffeeIngredient = new Coffee("Coffee", 1, 1);
        Water waterIngredient = new Water("Water", 0.2m, 1);

        Espresso<Ingredient> espressoRecipe = new Espresso<Ingredient>(coffeeIngredient, waterIngredient);

        decimal customProfitMargin =1.3m; // Set your custom profit margin here
        Drink<Espresso<Ingredient>, Ingredient> espressoDrink = new Drink<Espresso<Ingredient>, Ingredient>(espressoRecipe, customProfitMargin);

        decimal calculatedCost = Math.Round(espressoDrink.CalculateCost(), 2);

        // Output the results
        Console.WriteLine($"Calculated Cost: {calculatedCost}");

    }
}