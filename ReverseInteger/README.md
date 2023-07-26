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

# Unit Testing
```c
$cd tests
$dotnet test
```
