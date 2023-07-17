# ResDiary Coding Challenge
_Lewis Hotchen_

_17/07/2023_

## Assumptions
- Testing Librarys are allowed (NUnit)
- The Method was to be encapsulated into a class to be tested

## Test Data
Along with the example data provided I wanted to important kinds of test data which were:

``(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11}, 4)``

This data would give an uneven grouping that was different from the example given of ```[[1,2][3,4][5]]```, instead it would be ```[[1,2,3][4,5,6][7,8,9][10,11]]```.

And test data of:

```(new int[] { 1, 2, 3 }, 1)```

Which would ultimately give ```[[1,2,3]]``` which proves that the solution would evenly group in exact multiples (in this case 3x1)

## Solution
My solution to this challenge was to break down the largest possible groups that I could, by dividing the number of elements in a group by the length of the input array. Then, once I have that I can determine if there are any "trailing" elements in the array, that way I would know if the arrray would not split evenly, and I could group the remaning numbers. This could be done by simply using modulus, and seeing if there was a remained, which conveniently, was the remainder count of elements for the trailing group. From there it is just a matter of populating the arrays with the grouped elements (using Array.Copy for convenience) and adding them to our jagged array to return.

This program was written in .NET 7, C# with Visual Studio, in a console application.
