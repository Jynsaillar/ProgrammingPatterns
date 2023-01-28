using Programming_Patterns.Patterns.StrategyPattern.Version1;

namespace Programming_Patterns
{
    public static class Program
    {
        static void Main(string[] args)
        {
            SortOperation sortOperation = new();
            ReverseSortOperation reverseSortOperation = new();

            List<string> input = new()
            {
                "Test",
                "Words",
                "Apple",
                "Banana",
                "Car"
            };

            Operations operations = new(sortOperation);

            operations.SetStorage(input);
            operations.ShowStorageContents();
            operations.Operate();
            operations.ShowStorageContents();

            operations.SetOperation(reverseSortOperation);
            operations.ShowStorageContents();
            operations.Operate();
            operations.ShowStorageContents();

            Console.ReadKey();
        }
    }
}
