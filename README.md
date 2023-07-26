# DotNet Problems
General problems to practice

- ### [Add Two Numbers](https://github.com/zinuhe/dotNet-problems/tree/main/AddTwoNumbers)

- ### [Longest Substring Without Repeating Characters](https://github.com/zinuhe/dotNet-problems/tree/main/LongestSubstringWithoutRepeatingCharacters)

- ### [Reverse Integer](https://github.com/zinuhe/dotNet-problems/tree/main/ReverseInteger)



## Unit Test

Using  xTest

## Troubleshooting
### The issue
If encounter
```c
error CS0246: The type or namespace name 'Xunit' could not be found (are you missing a using directive or an assembly reference?)
```
Or
```c
error CS0246: The type or namespace name 'FactAttribute' could not be found (are you missing a using directive or an assembly reference?)
```

Or
```c
error CS0246: The type or namespace name 'Fact' could not be found (are you missing a using directive or an assembly reference?)
```

### The solution

Do not nest csproj. Note how [Microsoft's xunit setup guide](https://learn.microsoft.com/en-gb/dotnet/core/testing/unit-testing-with-dotnet-test) puts the main csproj and its tests csproj into different subdirectories of the sln.

I first ran into this error as well and after restructuring the project to not nest csproj, the error was resolved; with only the tests csproj referencing xunit.

Or

It was solved by typing "Restart Omnisharp" in the Command Palette.

### The issue
```c
error CS0579: Duplicate 'global::System.Runtime.Versioning.TargetFrameworkAttribute'
```
### The solution
The problem is about folder structure: the test project was in the main project folder. Passing each side by side in the same repo solved the problem

```c
MyProject
   src/MyProject.csproj
   tests/MyTestProject.csproj
```
Taken from Github issue : [https://github.com/dotnet/core/issues/4837](https://github.com/dotnet/core/issues/4837)

Or

This one doesn't fix the issue only hidden it

Add the following two lines to the ```<PropertyGroup>```.
```c
<PropertyGroup>
    <GenerateTargetFrameworkAttribute>false</GenerateTargetFrameworkAttribute>
</PropertyGroup>
```
