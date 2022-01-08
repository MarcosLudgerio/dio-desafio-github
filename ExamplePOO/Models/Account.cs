namespace ExamplePOO.Models
{
    public abstract class Account
    {
        protected double Sale;

        public abstract void Credit(double value);

        public void ShowSale()
        {
            System.Console.WriteLine("Seu saldo é: " + this.Sale);
        }
    }
}