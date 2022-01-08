namespace ExamplePOO.Models
{
    public sealed class Diretor : Professor
    {
        public override void Show()
        {
            Console.WriteLine($"Olá, meu nome é {base.Name}, sou diretorn e ganho R${base.Salary}");
        }
    }
}
