namespace ExamplePOO.Models
{
    public class CheckingAccount : Account
    {
        public override void Credit(double valor)
        {
            base.Sale += valor;
        }
    }
}