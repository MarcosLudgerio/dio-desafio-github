namespace Collections.Helper
{
    public class ArrayOperations
    {
        public void showArray(int[] list)
        {
            string linha = string.Join(", ", list);
            System.Console.WriteLine("[" + linha + "]");
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

        public void Ordenation(int[] list)
        {
            Array.Sort(list);
        }
        public void Copy(int[] list, int[] listTarget)
        {
            Array.Copy(list, listTarget, list.Length);
        }

        public bool isPresents(int[] list, int value)
        {
            return Array.Exists(list, element => element == value);
        }
    }


}