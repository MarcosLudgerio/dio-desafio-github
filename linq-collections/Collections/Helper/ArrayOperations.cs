namespace Collections.Helper
{
    public class ArrayOperations
    {
        public void showArray(int[] list)
        {
            System.Console.Write("[");
            for (int i = 0; i < list.Length - 1; i++)
            {
                System.Console.Write(list[i] + ", ");
            }
            System.Console.WriteLine(list[list.Length - 1] + "]");
        }

        public void ordenationBublleSort(int[] list)
        {
            int tmp = 0;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        tmp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = tmp;
                    }
                }
            }
        }

    }


}