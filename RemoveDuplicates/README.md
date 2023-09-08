# Remove Duplicates

Remove duplicates from an ordered array of integers in place

## Install BenchmarkDotNet

Run inside of the project folder

```shell
dotnet add package BenchmarkDotNet
```

Add

```csharp
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

```

To execute the benchmarks, set the compile mode of the project to Release and run the following command in the same folder where your project file resides:

```shell
dotnet run -p BenchmarkingConsoleDemo.csproj -c Release
```

## What's missing

- Implement Benchmark
- Verified the array content in the Unit Test
