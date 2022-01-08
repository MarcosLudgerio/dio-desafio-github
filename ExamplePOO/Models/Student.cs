namespace ExamplePOO.Models
{
    public class Student : Person
    {
        public double Note { get; set; }

        public override void Show()
        {
            Console.WriteLine($"Olá, meu nome é {this.Name}, sou aluno e minha nota é {this.Note}");
        }
    }
}