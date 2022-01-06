namespace ExamplePOO.Models
{
    public class Professor : Pessoa
    {
        public double Salary { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Olá, meu nome é {this.Name}, sou professor e ganho R${this.Salary}");
        }
    }
}