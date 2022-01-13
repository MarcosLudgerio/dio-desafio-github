namespace Collections.Helper
{
    public class QueueOperations
    {
        public void ShowValues(Queue<string> queue)
        {
            foreach (var item in queue)
            {
                System.Console.WriteLine($"{item}");
            }
        }

        public void RemoveValues(Queue<string> queue)
        {
            while (queue.Count > 0)
            {
                System.Console.WriteLine("Livro último da pilha: " + queue.Peek());
                queue.Dequeue();
            }
        }

        public void AddValue(Queue<string> queue, string value)
        {
            queue.Enqueue(value);
        }

        public void DeleteValue(Queue<string> queue)
        {
            queue.Dequeue();
        }
    }
}