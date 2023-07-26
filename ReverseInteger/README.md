## Reverse Integer

Given a signed 32-bit integer ```x```, return ```x``` with its digits reversed.
If reversing ```x``` causes the value to go outside the signed 32-bit integer
range [$2^{31} <= x <= 2^{31} - 1$], then return 0.

Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

## Example 1:
```c
Input: x = 123
Output: 321
```

## Example 2:
```c
Input: x = -123
Output: -321
```

## Example 3:
```c
Input: x = 120
Output: 21
```
## Constraints:
$2^{31} <= x <= 2^{31} - 1$

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

