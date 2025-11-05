// See https://aka.ms/new-console-template for more information
using System;
using Task2;

class Program
{
    static void Main(string[] args)
    {
        // Try to change the constant value (uncomment next line to see error)
        // Circle.PI = 3.14159;   // ❌ Error: You cannot change a constant value

        // Explanation:
        // PI is a constant, so its value cannot be changed once given.

        Circle c = new Circle();

        double radius = 5;

        Console.WriteLine("Area of circle: " + c.FindArea(radius));
        Console.WriteLine("Perimeter of circle: " + c.FindPerimeter(radius));
    }
}