namespace Collections.Helper
{
    public class ArrayOperations
    {
        Random random = new Random();
        public void ShowArray(int[] list)
        {
            string linha = string.Join(", ", list);
            System.Console.WriteLine("[" + linha + "]");
        }

        public int[] GeneratedArrayLength10Random()
        {
            int[] array = new int[10];
            // Insert Random values in list
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }

            return array;

        }
        public void OrdenationBublleSort(int[] list)
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

        public bool IsPresents(int[] list, int value)
        {
            return Array.Exists(list, element => element == value);
        }

        public bool BiggerThen(int[] list, int value)
        {
            return Array.TrueForAll(list, element => element > value);
        }

        public int GetVaue(int[] list, int value)
        {
            return Array.Find(list, element => element == value);
        }

        public int GetIndexValue(int[] list, int value)
        {
            return Array.IndexOf(list, value);
        }

        public void Resize(ref int[] list, int newLength)
        {
            Array.Resize(ref list, newLength);
        }

        public void ConvertToString(int[] list)
        {
            Array.ConvertAll(list, element => element.ToString());
        }

    }


}