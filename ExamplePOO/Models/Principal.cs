namespace ExamplePOO.Models
{
    public sealed class Principal : Professor
    {
        public override void Show()
        {
            Console.WriteLine($"Olá, meu nome é {base.Name}, sou diretorn e ganho R${base.Salary}");
        }
    }
}
