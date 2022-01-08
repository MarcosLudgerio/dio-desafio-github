namespace ExamplePOO.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Document { get; set; }

        public virtual void Show()
        {
            Console.WriteLine($"Olá, meu nome é {this.Name} e tenho {this.Age} anos. Meu Documento é {this.Document}");
        }
    }
}