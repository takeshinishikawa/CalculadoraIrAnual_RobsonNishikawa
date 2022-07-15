namespace CalculadoraIrAnual.Infrastructure
{
    public static class ScreenPresenter
    {
        public static string Show(string screen, string errorMessage = "")
        {
            AskValue:
            Console.Clear();
            Console.WriteLine(screen);
            string response = Console.ReadLine().Replace(".", "");
            while (string.IsNullOrWhiteSpace(response))
            {
                Console.WriteLine(errorMessage);
                Console.ReadKey();
                goto AskValue;
            }
            return response;
        }

        public static double GetInput(
            string screen,
            string errorMessage)
        {
            double response;
            string input = Show(screen, errorMessage);

            if (!double.TryParse(input, out response) || response < 0)
            {
                ScreenPresenter.PrintMessage(errorMessage);
                return -1;
            }
            return response;
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
