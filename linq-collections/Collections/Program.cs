using Collections.Helper;

namespace Collections
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            List<string> states = new List<string>() { "CE", "PB", "PE" };
            string[] statesArray = new string[2] { "BA", "RN" };

            // states.AddRange(statesArray);

            states.Insert(1, "RN");


            ListOperations opList = new ListOperations();

            // opList.AddElement(states, "SP");

            opList.ShowItemsList(states);

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