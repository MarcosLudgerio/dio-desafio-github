namespace ExamplesConstructors.Models
{
    public class Person
    {
        private string Name;
        private readonly string Lastname;

        // public Person()
        // {
        //     this.Name = string.Empty;
        //     this.Name = string.Empty;
        // }
        public Person(string name, string lastname)
        {
            this.Name = name;
            this.Lastname = lastname;
        }

        public void Show()
        {
            System.Console.WriteLine($"Olá, meu nome é {this.Name} e meu sobre nome é {this.Lastname}");
        }
    }
}