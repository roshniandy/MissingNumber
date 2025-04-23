
using MissingNumberDemo.FindMissing;

namespace FindMissingNumber.Input
{
    public class InputConsoleService : IInputService
    {
        public int[] ReadNumbers()
        {

            Console.WriteLine("Enter the numbers separated by commas: ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("Input cannot be empty.");
            }

            try
            {
                var inputArr = input.Split(',').Select(x => int.Parse(x)).ToArray();
                return inputArr;
            }
            catch (FormatException ex)
            {
                //Console.WriteLine("Input is invalid. Only numbers allowed. Numbers should be separated by commas");
                throw ex;
                // return ReadNumbers();
            }

        }

        public AlgorithmType SelectAlgorithm()
        {
            Console.WriteLine("Select the algorithm you wish to find the missing number (Type the sequence number):");
            Console.WriteLine("1. Sum of n terms Formula (Default)");
            Console.WriteLine("2. XOR Operation");

            var input = Console.ReadLine();
            return input switch
            {
                "2" => AlgorithmType.Xor,
                _ => AlgorithmType.Sum
            };
        }

        public bool ChoiceToContinue()
        {
            Console.WriteLine("\nWould you like to try another number sequence? (y/n):");
            return Console.ReadLine()?.Trim().ToLower() == "y";
        }
    }
}
