namespace ProgrammingPatterns.Patterns.MementoPattern
{
    public interface IHistory<T>
    {
        public void Push(T historyElement);
        public T Pop();
        public T Peek();
    }
}
