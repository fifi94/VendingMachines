using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using VendingMachine;
using VendingMachine.Drinks;
using VendingMachine.Ingredients;
using VendingMachine.Recipies;
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
            double customProfitMargin = 1.3;

            Coffee coffeeIngredient = new Coffee("Coffee", 1, 1);
            Water waterIngredient = new Water("Water", 0.2, 1);
            Espresso<Ingredient> espressoRecipe = new Espresso<Ingredient>(coffeeIngredient, waterIngredient);
            Drink<Espresso<Ingredient>, Ingredient> espressoDrink = new Drink<Espresso<Ingredient>, Ingredient>(espressoRecipe, customProfitMargin);

            // Act
            double calculatedCost = espressoDrink.CalculateCost();

            // Assert
            double expectedCost = 1.56; // (1 * 1 + 0.2 * 1) * 1.3
            Assert.AreEqual(expectedCost, calculatedCost, "Espresso cost calculation is correct.");

        }

        [TestMethod]
        public void TestLongCoffeeCostCalculation()
        {
            // Arrange
            Coffee coffeeIngredient = new Coffee("Coffee", 1, 1);
            Water waterIngredient = new Water("Water", 0.2, 2);
            double customProfitMargin = 1.3;
            LongCoffee<Ingredient> longCoffeRecipe = new LongCoffee<Ingredient>(coffeeIngredient, waterIngredient);
            Drink<LongCoffee<Ingredient>, Ingredient> allongeDrink = new Drink<LongCoffee<Ingredient>, Ingredient>(longCoffeRecipe, customProfitMargin);

            // Act
            double calculatedCost = allongeDrink.CalculateCost();

            // Assert
            double expectedCost = 2.08; // (1 * 1 + 0.2 * 2) * 1.3
            Assert.AreNotEqual(expectedCost, calculatedCost, "Allongé cost calculation is incorrect.");


        }

        [TestMethod]
        public void TestCappuccinoCostCalculation()
        {
            // Arrange
            Coffee coffeeIngredient = new Coffee("Coffee", 1, 1);
            Chocolate chocolateIngredient = new Chocolate("Chocolate", 1, 1);
            Water waterIngredient = new Water("Water", 0.2, 1);
            Cream creamIngredient = new Cream("Cream", 0.5, 1);

            Cappuccino<Ingredient> cappuccinoRecipe = new Cappuccino<Ingredient>(coffeeIngredient, chocolateIngredient, waterIngredient, creamIngredient);
            Drink<Cappuccino<Ingredient>, Ingredient> cappuccinoDrink = new Drink<Cappuccino<Ingredient>, Ingredient>(cappuccinoRecipe, 1.3);

            // Act
            double calculatedCost = cappuccinoDrink.CalculateCost();

            // Assert
            double expectedCost = 3.9; // (1 * 1 + 1 * 1 + 0.2 * 1 + 0.5 * 1) * 1.3
            Assert.AreNotEqual(expectedCost, calculatedCost, "Cappuccino cost calculation is incorrect.");
        }

        [TestMethod]
        public void TestHotChocolateCostCalculation()
        {
            double customProfitMargin = 1.3;

            // Create specific ingredient instances
            Chocolate chocolateIngredient = new Chocolate("Chocolate", 1, 3);
            Milk milkIngredient = new Milk("Milk", 0.4, 2);
            Water waterIngredient = new Water("Water", 0.2, 1);
            Sugar sugarIngredient = new Sugar("Sugar", 0.1, 1);

            // Create generic HotChocolate recipe
            HotChocolate<Ingredient> hotChocolateRecipe = new HotChocolate<Ingredient>(chocolateIngredient, milkIngredient, waterIngredient, sugarIngredient);

            // Create generic HotChocolate drink
            Drink<HotChocolate<Ingredient>, Ingredient> hotChocolateDrink = new Drink<HotChocolate<Ingredient>, Ingredient>(hotChocolateRecipe, customProfitMargin);

            // Act
            double calculatedCost = Math.Round(hotChocolateDrink.CalculateCost(), 2);

            // Assert
            double expectedCost = 5.33; // (3 * 1 + 2 * 0.4 + 0.2 * 1 + 0.1 * 1) * 1.3
            Assert.AreEqual(expectedCost, calculatedCost, "Hot Chocolate cost calculation is correct.");
        }

        [TestMethod]
        public void TestTeaCostCalculation()
        {
            double customProfitMargin = 1.3;

            // Create specific ingredient instances
            Tea teaIngredient = new Tea("Tea", 2, 1);
            Water waterIngredient = new Water("Water", 0.2, 2);

            // Create generic TeaDrink recipe
            TeaDrink<Ingredient> teaRecipe = new TeaDrink<Ingredient>(teaIngredient, waterIngredient);

            // Create generic TeaDrink drink
            Drink<TeaDrink<Ingredient>, Ingredient> teaDrink = new Drink<TeaDrink<Ingredient>, Ingredient>(teaRecipe, customProfitMargin);

            // Act
            double calculatedCost = Math.Round(teaDrink.CalculateCost(), 2);

            // Assert
            double expectedCost = 3.12; // (2 * 1 + 0.2 * 2) * 1.3
            Assert.AreEqual(expectedCost, calculatedCost, "Tea cost calculation is correct.");
        }
        [TestMethod]
        public void TestInvalidRecipe()
        {
            // Arrange
            Coffee coffeeIngredient = new Coffee("Coffee", 1, 1);
            Milk milkIngredients = new Milk("Milk", 0.2, 1);

            // Mock the GetIngredients method to return the unexpected recipe
            var mockRecipe = new Mock<Espresso<Ingredient>>();
            mockRecipe.Setup(r => r.GetIngredients()).Throws(new ArgumentException());

            double customProfitMargin = 1.3;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Drink<Recipe<Ingredient>, Ingredient>(mockRecipe.Object, customProfitMargin));

        }

        [TestMethod]
        public void TestNegativeDose()
        {
            // Arrange
            var mockIngredient = new Mock<Coffee>("Cofee",1,-5);

            var mockWaterIngredient = new Mock<Water>("Water", 1, 1);

            var mockEspressoRecipe = new Mock<Espresso<Ingredient>>(mockIngredient, mockWaterIngredient);
            mockEspressoRecipe.Setup(r => r.GetIngredients()).Throws<ArgumentException>();

            var mockRecipe = mockEspressoRecipe;

            double customProfitMargin = 1.3;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Drink<Recipe<Ingredient>, Ingredient>(mockRecipe.Object, customProfitMargin));
        }

        [TestMethod]
        public void TestZeroDose()
        {
            // Arrange
            var mockIngredient = new Mock<Coffee>("Cofee", 1, 0);

            var mockWaterIngredient = new Mock<Water>("Water", 1, 1);

            var mockEspressoRecipe = new Mock<Espresso<Ingredient>>(mockIngredient, mockWaterIngredient);
            mockEspressoRecipe.Setup(r => r.GetIngredients()).Throws<ArgumentException>();

            var mockRecipe = mockEspressoRecipe;

            double customProfitMargin = 1.3;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Drink<Recipe<Ingredient>, Ingredient>(mockRecipe.Object, customProfitMargin));
        }
    }



}

