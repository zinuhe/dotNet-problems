# Remove Duplicates from Sorted Array

Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

    Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
    Return k.

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
