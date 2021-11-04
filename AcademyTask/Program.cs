using System;

namespace AcademyTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int yearOfPurchase = int.Parse(Console.ReadLine());
            int yearOfTaxCalculation = int.Parse(Console.ReadLine());
            int lightMilesTraveled = int.Parse(Console.ReadLine());

            Calculation calc = new Calculation();
            int final = calc.CalculationTax(type, yearOfPurchase, yearOfTaxCalculation, lightMilesTraveled);
            Console.WriteLine(final);


        }
    }
}
