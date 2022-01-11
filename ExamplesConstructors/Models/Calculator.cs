namespace ExamplesConstructors.Models
{
    public class Calculator
    {
        public delegate void DelegateCalculator();

        public static event DelegateCalculator EventCalculator;
        public static void Sum(int x, int y)
        {
            if (EventCalculator != null)
            {
                System.Console.WriteLine($"Adição: {x + y}");
                EventCalculator();
            }
            else
            {
                System.Console.WriteLine("Nenhum inscrito");
            }
        }

        public static void Sub(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }
    }
}




