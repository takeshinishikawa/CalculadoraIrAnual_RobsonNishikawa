namespace CalculadoraIrAnual.Presentation.Screens
{
    public static class Messages
    {
        public const string AskAnualValeu = @"
Informe o valor do faturamento anual (Formato: ###.###.###,##):";
        public const string InvalidInput = @"
O valor informado é inválido";
        public static string ValueToPay(double value)
        {
            return $@"O valor a ser pago é de {value.ToString("C")}";
        }
    }
}
