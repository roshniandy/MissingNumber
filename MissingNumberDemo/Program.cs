
using FindMissingNumber;
using FindMissingNumber.FindMissing;
using FindMissingNumber.Input;
using FindMissingNumber.Output;
using Microsoft.Extensions.DependencyInjection;
using MissingNumberDemo;
using MissingNumberDemo.FindMissing;

ServiceCollection services = new();
services.AddSingleton<IInputService, InputConsoleService>();
services.AddSingleton<IOutputService, OutputConsoleService>();
services.AddSingleton<IMissingNumberService, MissingNumberService>();

services.AddKeyedSingleton<IFindMissingNumber, FindMissingNumberSum>(AlgorithmType.Sum);
services.AddKeyedSingleton<IFindMissingNumber, FindMissingNumberXor>(AlgorithmType.Xor);

var provider = services.BuildServiceProvider();

IMissingNumberService missingNumberService = provider.GetRequiredService<IMissingNumberService>();


missingNumberService.Execute();
