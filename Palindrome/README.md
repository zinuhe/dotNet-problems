# Palindrome

A word, phrase, or sequence that reads the same backward as forward.

## How to run the code

```shell
dotnet run --project Palindrome
```

## How to run the tests

```shell
dotnet test
```

## Implementations

Two different implementations of it

### First approach `IsPalindromeV1`

The simplest, convert the string to a char array, then use the `Array.Reverse(toReverse)` method, convert it back to a string and compare it with the original string.

### Second approach `IsPalindromeV2`

Use a kind of sliding window comparing the extremes and moving towards the center.
