namespace ExamplesConstructors.Models
{
    public class Mathematic
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Mathematic(int x, int y)
        {
            X = x;
            Y = y;

            Calculator.EventCalculator += EventHandler;
        }

        public void Sum()
        {
            Calculator.Sum(X, Y);
        }

        public void EventHandler()
        {
            System.Console.WriteLine("Método executado");
        }
    }
}