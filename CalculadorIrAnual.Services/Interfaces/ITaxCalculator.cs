using CalculadorIrAnual.Domain;
using System;
namespace CalculadorIrAnual.Services.Interfaces
{
    public interface ITaxCalculator
    {
        double TaxCalculation(double value);
        public void SetTaxCalculatorVars(double value, TableLine line);
    }

}