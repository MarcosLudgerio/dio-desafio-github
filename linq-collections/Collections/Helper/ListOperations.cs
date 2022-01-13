namespace Collections.Helper
{
    public class ListOperations
    {


        public void ShowItemsList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                System.Console.WriteLine(list[i]);
            }
        }



        public void AddElement(List<string> list, string element)
        {
            list.Add(element);
        }

        public void RemoveElement(List<string> list, string element)
        {
            list.Remove(element);
        }
    }
}