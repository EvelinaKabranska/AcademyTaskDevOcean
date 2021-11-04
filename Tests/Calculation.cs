using System;

namespace Tests
{
    public class Calculation
    {
        private string type;
        private int yearOfPurchase;
        private int yearOfTaxCalculation;
        private int lightMilesTraveled;

        public int CalculationTax(string type, int yearOfPurchase, int yearOfTaxCalculation, int lightMilesTraveled)
        {
            this.type = type;
            this.yearOfPurchase = yearOfPurchase;
            this.yearOfTaxCalculation = yearOfTaxCalculation;
            this.lightMilesTraveled = lightMilesTraveled;

            int cargoTax = 10000;
            int familyTax = 5000;
            int cargoLightTax = 1000;
            int famiyLightTax = 100;
            int cargoYearDecline = 736;
            int familyYearDecline = 355;
            int tax = 0;
            int lightTax = lightMilesTraveled / 1000;

            if (type.ToLower() == "cargo")
            {
                tax = cargoTax + lightTax * cargoLightTax - (yearOfTaxCalculation - yearOfPurchase) * cargoYearDecline;
            }
            else if (type.ToLower() == "family")
            {
                tax = familyTax + lightTax * famiyLightTax - (yearOfTaxCalculation - yearOfPurchase) * familyYearDecline;
            }
            else if (type.ToLower() != "cargo" || type.ToLower()!= "family")
            {
                throw new ArgumentException("The type is wrong! You must choose between Family and Cargo.");
            }

            return tax;
        }
    }
}