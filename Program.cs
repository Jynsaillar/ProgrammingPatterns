using ProgrammingPatterns.Patterns.StrategyPattern.Version1;

namespace ProgrammingPatterns
{
    public static class Program
    {
#pragma warning disable IDE0060 // Suppresses [Remove unused parameter 'args']
        static void Main(string[] args)
        {
#pragma warning restore IDE0060
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
