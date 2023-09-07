## Binary

In binary representation, the last digit (rightmost digit) of a number determines whether it's odd or even. If the last digit is '0', the number is even. If the last digit is '1', the number is odd.

## Division by 2

You can perform a binary division by 2 by shifting the digits of the binary string to the right.

We can achieve this by removing the last digit (rightmost bit) from the binary string using Substring. This is equivalent to performing a binary right shift operation.

## Substract 1 from the number

Subtracting 1 from a binary number is a bit more complex as it can involve borrowing across multiple digits

The SubtractOneFromBinary function takes a binary string as input and returns the result of subtracting 1 from it. It does this by starting from the rightmost digit and finding the first '1' digit. When it encounters the first '1', it subtracts 1 by converting that '1' to '0'. If the digit is '0', it borrows from the next digit by converting it to '1'.

Replace "101010" with your actual binary string, and the code will output the original binary string and the binary string after subtracting 1. Keep in mind that this approach assumes that the input binary string is not an all-zero string (i.e., it doesn't represent the number 0).
