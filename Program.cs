// See https://aka.ms/new-console-template for more information
using System;


int[] favoriteNumbers = { 7, 3, 9, 1, 5 };


Array.Sort(favoriteNumbers);


Array.Reverse(favoriteNumbers);


Console.WriteLine("Array elements:");
for (int i = 0; i < favoriteNumbers.Length; i++)
{
    Console.WriteLine(favoriteNumbers[i]);
}


int searchNumber = 7;
int position = Array.IndexOf(favoriteNumbers, searchNumber);
Console.WriteLine($"\nNumber {searchNumber} is at index: {position}");
