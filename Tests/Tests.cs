using NUnit.Framework;
using System;
using AcademyTask;

namespace Tests
{
    public class FamilyTest
    {
        [Test]
        [TestCase("Family", 2300, 2307, 2344)]

        public void CorrectFamilyProperties(string type, int yearOfPurchase, int yearOfTaxCalculation, int lightMilesTraveled)
        {
            Calculation calc = new Calculation();
            Assert.AreEqual(5000 + 2 * 100 - 7 * 355, calc.CalculationTax("Family", 2300, 2307, 2344));

        }
    }
    public class CargoTest
    {
        [Test]
        [TestCase("Cargo", 2332, 2369, 344789)]
        public void CorrectCargoProperties(string type, int yearOfPurchase, int yearOfTaxCalculation, int lightMilesTraveled)
        {
            Calculation calc = new Calculation();
            Assert.AreEqual(10000 + 344 * 1000 - (2369 - 2332) * 736, calc.CalculationTax("Cargo", 2332, 2369, 344789));

        }
    } 
}
