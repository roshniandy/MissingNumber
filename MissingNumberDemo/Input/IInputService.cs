
using MissingNumberDemo.FindMissing;

namespace FindMissingNumber.Input
{
    public interface IInputService
    {
        public int[] ReadNumbers();
        public AlgorithmType SelectAlgorithm();
        public bool ChoiceToContinue();

    }
}
