namespace Collections.Helper
{
    public class DictionaryOperations
    {
        public void ShowValues(Dictionary<string, string> dictionary)
        {
            foreach (var item in dictionary)
            {
                System.Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        public void AddValue(Dictionary<string, string> dictionary, string key, string value)
        {
            dictionary.Add(key, value);
        }

        public void FindValue(Dictionary<string, string> dictionary, string key)
        {
            System.Console.WriteLine(dictionary[key]);
        }

        public void UpdateValue(Dictionary<string, string> dictionary, string key, string newValue)
        {
            dictionary[key] = newValue;
        }

        public void DeleteValue(Dictionary<string, string> dictionary, string key)
        {
            dictionary.Remove(key);
        }
    }
}