using Collections.Helper;

namespace Collections
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            ArrayOperations op = new ArrayOperations();

            int[] numbers = op.GeneratedArrayLength10Random();
            op.ShowArray(numbers);


            var minimo = numbers.Min();
            var maximo = numbers.Max();
            var medium = numbers.Average();
            var sum = numbers.Sum();
            var numbersUnique = numbers.Distinct().ToArray();

            System.Console.WriteLine("Mínimo: " + minimo);
            System.Console.WriteLine("Máximo: " + maximo);
            System.Console.WriteLine("Média: " + medium);
            System.Console.WriteLine("Soma: " + sum);
            System.Console.WriteLine("Array original: " + string.Join(", ", numbers));
            System.Console.WriteLine("Array sem repetição: " + string.Join(", ", numbersUnique));

            // var numbersPars = from num in numbers where num % 2 != 0 orderby num select num;

            // var numbersParsMethodds = numbers.Where(x => x % 2 != 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("Números ímpares: " + string.Join(", ", numbersParsMethodds));
            // System.Console.WriteLine("Números ímpares: " + string.Join(", ", numbersPars));

            // Dictionary<string, string> states = new Dictionary<string, string>();

            // states.Add("CE", "Ceará");
            // states.Add("PB", "Paraíba");
            // states.Add("PI", "Piauí");

            // // foreach (var item in states)
            // // {
            // //     System.Console.WriteLine($"{item.Key}: {item.Value}");
            // // }

            // string key = "PI";
            // System.Console.WriteLine(states[key]);

            // states[key] = "PIAUì";
            // System.Console.WriteLine(states[key]);

            // states.Remove(key);

            // Stack<string> books = new Stack<string>();

            // books.Push(".NET");
            // books.Push("Java");
            // books.Push("Python");

            // System.Console.WriteLine($"Existem {books.Count} livros na pilha");
            // while (books.Count > 0)
            // {
            //     System.Console.WriteLine("Livro último da pilha: " + books.Peek());
            //     books.Pop();
            // }
            // System.Console.WriteLine($"Existem {books.Count} livros na pilha");

            // Queue<string> queue = new Queue<string>();

            // queue.Enqueue("Frank");
            // queue.Enqueue("Dayse");
            // queue.Enqueue("Dyen");


            // System.Console.WriteLine($"Há {queue.Count} Pessoas na fila");
            // while (queue.Count > 0)
            // {
            //     System.Console.WriteLine("Vez de " + queue.Peek());
            //     queue.Dequeue();
            // }
            // System.Console.WriteLine($"Há {queue.Count} Pessoas na fila");

            // List<string> states = new List<string>() { "CE", "PB", "PE" };
            // string[] statesArray = new string[2] { "BA", "RN" };

            // // states.AddRange(statesArray);

            // states.Insert(1, "RN");


            // ListOperations opList = new ListOperations();

            // // opList.AddElement(states, "SP");

            // opList.ShowItemsList(states);

            // System.Console.WriteLine("REMOVENDO O ELEMENTO SP");
            // states.Remove("SP");

            // opList.ShowItemsList(states);


            // int[] arrayInt = new int[3];

            // arrayInt[0] = 6;
            // arrayInt[1] = 7;
            // arrayInt[2] = 5;

            // System.Console.WriteLine("Varrendo array pelo for");
            // for (int i = 0; i < arrayInt.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInt[i]);
            // }

            // System.Console.WriteLine("Varrendo array com foreach");
            // foreach (var item in arrayInt)
            // {
            //     System.Console.WriteLine(item);
            // }

            // int[,] matrix = new int[4, 4];

            // //
            // for (int i = 0; i < matrix.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         matrix[i, j] = random.Next(0, 100);
            //     }
            // }

            // for (int i = 0; i < matrix.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matrix[i, j]);
            //     }
            // }
            // Random random = new Random();
            // int[] list = new int[5];
            // int[] listCopy = new int[10];
            // // Insert Random values in list
            // for (int i = 0; i < list.Length; i++)
            // {
            //     list[i] = random.Next(1, 10);
            // }

            // // Ordenation Alghoritim
            // ArrayOperations op = new ArrayOperations();
            // op.ordenationBublleSort(list);
            // op.Ordenation(list);

            // op.showArray(listCopy);
            // op.Copy(list, listCopy);

            // System.Console.WriteLine(op.IsPresents(list, 7));


            // op.ShowArray(list);
            // System.Console.WriteLine(op.BiggerThen(list, 1));

            // op.ShowArray(list);
            // System.Console.WriteLine(op.GetVaue(list, 5));

            // op.ShowArray(list);
            // System.Console.WriteLine(op.GetIndexValue(list, 5));

            // System.Console.WriteLine(list.Length);
            // op.Resize(ref list, list.Length * 2);
            // System.Console.WriteLine(list.Length);

            // op.ShowArray(list);
            // op.ConvertToString(list);
            // op.ShowArray(list);

        }
    }
}