namespace SharpPrinciples.Geometry;
public class Circle(double radius)
{
    public double Radius { get; set; } = radius;

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    // So what will happen if you don't override ToString()?
    /*
        if I do this Console.WriteLine(circle); printing Circle class object it will give me result
            SharpPrinciples.Geometry.Circle
        Or if I override ToString(), It will give result what I want in override method 
     */
    public override string ToString()
    {
        return $"Circle with radius {Radius}, area {GetArea():F2}";
    }
}
