namespace ExamplesConstructors.Models
{
    public class Date
    {
        private int month;
        private bool valide;

        public int Month
        {
            get
            {
                return this.month;
            }
            set
            {
                if (value > 0 && value < 13)
                {
                    this.month = value;
                    this.valide = true;
                }
            }
        }
        public void showMonth()
        {
            if (this.valide) System.Console.WriteLine(this.Month);
            else System.Console.WriteLine("Inválido");
        }
    }
}