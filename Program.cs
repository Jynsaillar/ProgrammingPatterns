using ProgrammingPatterns.Patterns.MementoPattern;
using ProgrammingPatterns.Patterns.StrategyPattern.Variant1;

namespace ProgrammingPatterns
{
    public static class Program
    {
#pragma warning disable IDE0060 // Suppresses [Remove unused parameter 'args']
        static void Main(string[] args)
        {
#pragma warning restore IDE0060
            MementoPatternTest();
            Console.ReadKey();
        }

        // TODO: Move this function to a separate class
        static void OperationsPatternTest() {

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


        }

        // TODO: Move this function to a separate class
        static void MementoPatternTest() {
            var editor = new Editor(content: "", history: new StringHistory());
            editor.SetContent("a");
            editor.SetContent("b");
            editor.SetContent("c");
            editor.Undo();
            Console.WriteLine($"Current editor content: {editor.GetContent()}");
        }
    }
}
