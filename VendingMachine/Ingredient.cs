using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    // Abstract class representing an ingredient
    public abstract class Ingredient
    {
        public string Name { get; }
        public decimal PricePerDose { get; }
        public decimal Dose { get; }

        // Constructor for Ingredient with input validation
        protected Ingredient(string name, decimal pricePerDose,decimal dose)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));

            if (pricePerDose < 0)
                throw new ArgumentException("Price per dose cannot be negative.", nameof(pricePerDose));
            if (dose < 0)
                throw new ArgumentException("Dose cannot be negative.", nameof(pricePerDose));

            Name = name;
            PricePerDose = pricePerDose;
            Dose = dose;
        }
    }
}
