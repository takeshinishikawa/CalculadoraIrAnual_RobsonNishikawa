using CalculadoraIrAnual.Infrastructure;
using CalculadoraIrAnual.ProgramFlows.Interfaces;
using CalculadorIrAnual.Services.Interfaces;
using CalculadoraIrAnual.Presentation.Screens;
using CalculadorIrAnual.Domain;

namespace CalculadoraIrAnual.ProgramFlows
{
    public class MainFlow : IMainFlow
    {
        private readonly ITaxCalculator _taxCalculator;

        public MainFlow(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public void BeginApp()
        {
            GetAnualValue();
        }

        public void GetAnualValue()
        {
            double value = ScreenPresenter.GetInput(Messages.AskAnualValeu, Messages.InvalidInput);
            if (value != -1)
            {
                TableLine line = new();
                IrTable.GetLine(value, ref line);
                _taxCalculator.SetTaxCalculatorVars(value, line);
                double valueToPay = _taxCalculator.TaxCalculation(value);
                ScreenPresenter.PrintMessage(Messages.ValueToPay(valueToPay));
            }
            Console.ReadKey();
            BeginApp();
        }
    }
}
