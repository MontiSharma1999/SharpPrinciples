namespace SharpPrinciples.Geometry;
public class Rectangle(double length, double breadth) : IShape
{
    public double Length { get; set; } = length;
    public double Breadth { get; set; } = breadth;
    public double GetArea()
    {
        return Length * Breadth;
    }
    public override string ToString()
    {
        return $"Rectangle with length {Length} and breath {Breadth}, area {GetArea():F2}";
    }
}
