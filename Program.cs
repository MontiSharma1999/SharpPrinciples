using SharpPrinciples.Geometry;

namespace SharpPrinciples;
internal class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        CalculateArea(circle);
        Print(circle);
    }
    private static void CalculateArea(Circle circle)
    {
        double area = Math.PI * circle.Radius * circle.Radius;
        Console.WriteLine(area);
    }
    private static void Print(Circle circle) 
    {
        Console.WriteLine(circle);
    }
}
