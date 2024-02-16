using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendingMachine;
using Xunit.Sdk;
namespace UnitTest
{

    [TestClass]
    public class DrinkTests
    {

        [TestMethod]
        public void TestEspressoCostCalculation()
        {
            // Arrange
            decimal customProfitMargin = 1.3m;

            Coffee coffeeIngredient = new Coffee("Coffee", 1, 1);
            Water waterIngredient = new Water("Water", 0.2m, 1);
            Espresso<Ingredient> espressoRecipe = new Espresso<Ingredient>(coffeeIngredient, waterIngredient);
            Drink<Espresso<Ingredient>, Ingredient> espressoDrink = new Drink<Espresso<Ingredient>, Ingredient>(espressoRecipe, customProfitMargin);

            // Act
            decimal calculatedCost = espressoDrink.CalculateCost();

            // Assert
            decimal expectedCost = 1.56m; // (1 * 1 + 0.2 * 1) * 1.3
            Assert.AreEqual(expectedCost, calculatedCost, "Espresso cost calculation is correct.");
            
        }

        [TestMethod]
        public void TestAllongeCostCalculation()
        {
            // Arrange
            Coffee coffeeIngredient = new Coffee("Coffee", 1, 1);
            Water waterIngredient = new Water("Water", 0.2m, 2);
            decimal customProfitMargin = 1.3m;
            LongCoffee<Ingredient> allongeRecipe = new LongCoffee<Ingredient>(coffeeIngredient, waterIngredient);
            Drink<LongCoffee<Ingredient>, Ingredient> allongeDrink = new Drink<LongCoffee<Ingredient>, Ingredient>(allongeRecipe, customProfitMargin);

            // Act
            decimal calculatedCost = allongeDrink.CalculateCost();

            // Assert
            decimal expectedCost = 2.08m; // (1 * 1 + 0.2 * 2) * 1.3
            Assert.AreNotEqual(expectedCost, calculatedCost, "Allongé cost calculation is incorrect.");
           
            
        }

        [TestMethod]
        public void TestCappuccinoCostCalculation()
        {
            // Arrange
            Coffee coffeeIngredient = new Coffee("Coffee", 1, 1);
            Chocolate chocolateIngredient = new Chocolate("Chocolate", 1, 1);
            Water waterIngredient = new Water("Water", 0.2m, 1);
            Cream creamIngredient = new Cream("Cream", 0.5m, 1);

            Cappuccino<Ingredient> cappuccinoRecipe = new Cappuccino<Ingredient>(coffeeIngredient, chocolateIngredient, waterIngredient, creamIngredient);
            Drink<Cappuccino<Ingredient>, Ingredient> cappuccinoDrink = new Drink<Cappuccino<Ingredient>, Ingredient>(cappuccinoRecipe, 1.3m);

            // Act
            decimal calculatedCost = cappuccinoDrink.CalculateCost();

            // Assert
            decimal expectedCost = 3.9m; // (1 * 1 + 1 * 1 + 0.2 * 1 + 0.5 * 1) * 1.3
            Assert.AreNotEqual(expectedCost, calculatedCost, "Cappuccino cost calculation is incorrect.");
        }

        [TestMethod]
        public void TestHotChocolateCostCalculation()
        {
            decimal customProfitMargin = 1.3m;

            // Create specific ingredient instances
            Chocolate chocolateIngredient = new Chocolate("Chocolate", 1, 3);
            Milk milkIngredient = new Milk("Milk", 0.4m, 2);
            Water waterIngredient = new Water("Water", 0.2m, 1);
            Sugar sugarIngredient = new Sugar("Sugar", 0.1m, 1);

            // Create generic HotChocolate recipe
            HotChocolate<Ingredient> hotChocolateRecipe = new HotChocolate<Ingredient>(chocolateIngredient, milkIngredient, waterIngredient, sugarIngredient);

            // Create generic HotChocolate drink
            Drink<HotChocolate<Ingredient>, Ingredient> hotChocolateDrink = new Drink<HotChocolate<Ingredient>, Ingredient>(hotChocolateRecipe, customProfitMargin);

            // Act
            decimal calculatedCost = Math.Round(hotChocolateDrink.CalculateCost(), 2);

            // Assert
            decimal expectedCost = 5.33m; // (3 * 1 + 2 * 0.4 + 0.2 * 1 + 0.1 * 1) * 1.3
            Assert.AreEqual(expectedCost, calculatedCost, "Hot Chocolate cost calculation is correct.");
        }

        [TestMethod]
        public void TestTeaCostCalculation()
        {
            decimal customProfitMargin = 1.3m;

            // Create specific ingredient instances
            Tea teaIngredient = new Tea("Tea", 2, 1);
            Water waterIngredient = new Water("Water", 0.2m, 2);

            // Create generic TeaDrink recipe
            TeaDrink<Ingredient> teaRecipe = new TeaDrink<Ingredient>(teaIngredient, waterIngredient);

            // Create generic TeaDrink drink
            Drink<TeaDrink<Ingredient>, Ingredient> teaDrink = new Drink<TeaDrink<Ingredient>, Ingredient>(teaRecipe, customProfitMargin);

            // Act
            decimal calculatedCost = Math.Round(teaDrink.CalculateCost(), 2);

            // Assert
            decimal expectedCost = 3.12m; // (2 * 1 + 0.2 * 2) * 1.3
            Assert.AreEqual(expectedCost, calculatedCost, "Tea cost calculation is correct.");
        }

    }
}
