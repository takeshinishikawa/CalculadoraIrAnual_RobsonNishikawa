using CalculadorIrAnual.Services.Interfaces;
using CalculadorIrAnual.Domain;

namespace CalculadorIrAnual.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public double Aliquot { get; private set; }
        public double ValueToDeduce { get; private set; }
        public void SetTaxCalculatorVars(double value, TableLine line)
        {
            if (line.MaxRange != 0)
            {
                Aliquot = line.Aliquot;
                ValueToDeduce = line.ValueToDeduce;
            }
            else
            {
                Aliquot = 0;
                ValueToDeduce = 0;
            }
        }
        public double TaxCalculation(double value)
        {
            return (value * Aliquot) - ValueToDeduce;
        }
    }
}

