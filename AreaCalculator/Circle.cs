namespace AreaCalculator;

public class Circle : Figure
{
    private readonly double _radius;

    /// <summary>
    ///  Creates an instance of a triangle
    /// </summary>
    /// <param name="radius">sets the radius of the circle</param>
    /// <returns></returns>
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be greater than 0.");
        }
        _radius = radius;
    }

    public override double GetArea()
    {
        var area = Math.PI * Math.Pow(_radius, 2);
        return Math.Round(area, 4);
    }
}