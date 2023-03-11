namespace ProgrammingPatterns.Patterns.MementoPattern
{
    public class StringHistory : IHistory<string>
    {
        private Stack<string> _history;

        public StringHistory()
        {
            _history = new Stack<string>();
        }

        public string Pop()
        {
            return _history.Pop();
        }

        public void Push(string historyElement)
        {
            _history.Push(historyElement);
        }

        public string Peek()
        {
            return _history.Peek();
        }
    }
}
