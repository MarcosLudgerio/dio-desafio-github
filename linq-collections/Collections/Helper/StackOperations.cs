namespace Collections.Helper
{
    public class StackOperations
    {
        public void ShowValues(Stack<string> stack)
        {
            foreach (var item in stack)
            {
                System.Console.WriteLine($"{item}");
            }
        }

        public void RemoveValues(Stack<string> stack)
        {
            while (stack.Count > 0)
            {
                System.Console.WriteLine("Livro último da pilha: " + stack.Peek());
                stack.Pop();
            }
        }

        public void AddValue(Stack<string> stack, string value)
        {
            stack.Push(value);
        }

        public void DeleteValue(Stack<string> stack)
        {
            stack.Pop();
        }
    }
}