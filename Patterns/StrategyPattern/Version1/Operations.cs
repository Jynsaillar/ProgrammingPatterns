using System.Linq;

    namespace Programming_Patterns.Patterns.StrategyPattern.Version1
{
    public class Operations
    {
        private IOperation? _ioperation { get; set; }
        private List<string>? _storage { get; set; }

        private Operations()
        {

        }

        public Operations(IOperation operation)
        {
            this._ioperation = operation;
            _storage = new();
        }

        public void SetOperation(IOperation operation)
        {
            this._ioperation = operation;
        }

        public void Operate()
        {
            Console.WriteLine("Running operation on the input...");

            if (this._storage is null)
            {
                Console.WriteLine($"Storage is null!");
            }

            this._storage = this._ioperation.DoOperation(_storage);
            Console.WriteLine("Operation finished.");
        }

        public void ShowStorageContents()
        {
            if (_storage is null)
            {
                Console.WriteLine("Storage is null!");
                return;
            }
            if (_storage.Count == 0)
            {
                Console.WriteLine("Storage is empty.");
                return;
            }
            foreach (var entry in this._storage)
            {
                Console.WriteLine($"Storage entry: {entry.ToString()}");
            }
        }

        /// <summary>
        /// Updates internal storage container with user-provided contents.
        /// This WILL clear the internal storage beforehand, even if the user-provided content is empty!
        /// </summary>
        public void SetStorage(List<string> newStorageContents)
        {
            if (_storage is null)
                return;

            this._storage.Clear();

            if (newStorageContents is null)
                return;

            this._storage = newStorageContents;
        }
    }


    public class SortOperation : IOperation
    {
        public List<string> DoOperation(List<string> input)
        {
            // Alphabetical sorting
            return input.OrderBy(entry => entry).ToList();
        }
    }

    public class ReverseSortOperation : IOperation
    {
        public List<string> DoOperation(List<string> input)
        {
            // Reverse alphabetical sorting
            return input.OrderByDescending(entry => entry).ToList();
        }
    }

}
