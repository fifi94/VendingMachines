using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Ingredients
{
    // Abstract class representing an ingredient
    public abstract class Ingredient
    {
        public string Name { get; set; }
        public double PricePerDose { get; set; }
        public double Dose { get; set; }
        public Ingredient()
        {
                
        }
        // Constructor for Ingredient with input validation
        protected Ingredient(string name, double pricePerDose, double dose)
        {
            //ValidateDose();
            //ValidatePrice();
            //ValidateName();
            Name = name;
            PricePerDose = pricePerDose;
            Dose = dose;
        }
        public void ValidateDose()
        {
            if (Dose <= 0)
            {
                throw new ArgumentException("Invalid ingredient dose: Dose must be positif.");
            }
        }
        public void ValidateName()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(Name));
        }
        public void ValidatePrice()
        {
            if (PricePerDose <= 0)
            {
                throw new ArgumentException("Invalid price : Price must be positif.");
            }
        }

    }
}
