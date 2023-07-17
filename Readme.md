# ResDiary Coding Challenge
_Lewis Hotchen_

_17/07/2023_

My solution to this challenge was to break down the largest possible groups that I could, by dividing the number of elements in a group by the length of the input array. Then, once I have that I can determine if there are any "trailing" elements in the array, that way I would know if the arrray would not split evenly, and I could group the remaning numbers. This could be done by simply using modulus, and seeing if there was a remained, which conveniently, was the remainder count of elements for the trailing group. From there it is just a matter of populating the arrays with the grouped elements (using Array.Copy for convenience) and adding them to our jagged array to return.

This program was written in .NET 7, C# with Visual Studio, in a console application.
