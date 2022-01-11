using ExamplesConstructors.Models;

// Person p = new Person("Sam", "Smith");
// p.Show();

// Log l = Log.GetInstance();
// l.PropLog = "Propriedade 1";

// Log l2 = Log.GetInstance();

// System.Console.WriteLine(l2.PropLog); // Propriedade 1


// Date d = new Date();
// d.Month = 5;
// d.showMonth();


// const double pi = 3.14;
// System.Console.WriteLine(pi);


namespace ExamplesConstructors
{
    public class Principal
    {
        // Operation op = new Operation(Calculator.Sum);
        public delegate void Operation(int x, int y);
        public static void Main(String[] args)
        {
            // Operation op = Calculator.Sub;
            // op += Calculator.Sum;
            // op.Invoke(4, 2);
            // // op(4, 2);

            Mathematic mt = new Mathematic(5, 6);
            mt.Sum();
        }
    }
}





