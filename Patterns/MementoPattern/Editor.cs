namespace ProgrammingPatterns.Patterns.MementoPattern {
    public class Editor
    {
        private string? _content;
        private IHistory<string>? _history;

        public Editor(string? content, IHistory<string>? history)
        {
            _content = content;
            _history = history;
        }

        public string? GetContent() {
            return _content;
        }

        public void SetContent(string content) {
            this._content = content;
            this._history?.Push(content);
        }

        public void Undo()
        {
            this._history?.Pop();
            this._content =  this._history?.Peek();        }
    }
}
