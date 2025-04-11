using SharpPrinciples.Geometry;
using SharpPrinciples.Shared;

namespace SharpPrinciples;
internal class Program
{
    static void Main(string[] args)
    {
        IShape circle = new Circle(5);
        IShape rectangle = new Rectangle(6, 7);
        CalculateArea(rectangle);
        Printer.Print(rectangle);
    }

    /*  1. Single Resposibility Principle
        this does illustrate a violation of the Single Responsibility Principle (SRP).
        The Single Responsibility Principle (from SOLID principles) states that:
            A class should have only one reason to change.
            That is, each class should only do one thing.

        1. It calculates the area of a circle (CalculateArea method).
        2. It prints the circle (Print method).
        3. It also creates and manages the Circle object.
     */

    /*
    private static void CalculateArea(Circle circle)
    {
        double area = Math.PI * circle.Radius * circle.Radius;
        Console.WriteLine(area);
    }
    private static void Print(Circle circle)
    {
        Console.WriteLine(circle);
    }
    */

    // To follow SRP use it like move Print method into Seprate class that is resposible for printing something that
    // should be file, text etc, and next step to achieve SRP is move calculate area logic into Circle class
    // How it looks see below and compare it to above

    private static void CalculateArea(IShape shape)
    {
        double area = shape.GetArea();
        Console.WriteLine(area);
    }

    /* 2. Open(extension) / Closed(modification) Principle
        "Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification."
        Open for extension: You should be able to add new functionality or behavior to a class.
        Closed for modification: You shouldn't have to modify the existing code of a class to add new functionality.
     */
}
