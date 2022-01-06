namespace ExamplePOO.Models
{
    public class Pessoa
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Show()
        {
            Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos.");
        }
    }
}