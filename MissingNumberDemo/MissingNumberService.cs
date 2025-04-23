using FindMissingNumber.FindMissing;
using FindMissingNumber.Input;
using FindMissingNumber.Output;
using Microsoft.Extensions.DependencyInjection;
using MissingNumberDemo;

namespace FindMissingNumber
{
    public class MissingNumberService : IMissingNumberService
    {
        private readonly IServiceProvider _provider;
        private readonly IInputService _inputService;
        private readonly IOutputService _outputService;
        public MissingNumberService(IServiceProvider provider, IInputService inputService, IOutputService outputService)
        {
            this._provider = provider;
            this._inputService = inputService;
            this._outputService = outputService;
        }
        public void Execute()
        {

            do
            {
                try
                {
                    var nums = _inputService.ReadNumbers();
                    var selectedAlgorithm = _inputService.SelectAlgorithm();
                    IFindMissingNumber _findMissingNumber = _provider.GetKeyedService<IFindMissingNumber>(selectedAlgorithm);
                    int result = _findMissingNumber.GetMissingNumber(nums);
                    _outputService.PrintResult($"Missing number is: {result}");
                }
                catch (Exception ex)
                {
                    _outputService.PrintError($"Error occurred: {ex.Message}");
                }

            } while (_inputService.ChoiceToContinue());
        }
    }
}
