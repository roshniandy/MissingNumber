
namespace FindMissingNumber.Output
{
    public class OutputConsoleService : IOutputService
    {
        public void PrintResult(string message)
        {

            Console.WriteLine(message);
        }

        public void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
