namespace AreaCalculator;

public class Triangle : Figure
{
    private readonly double[] _sides;

    /// <summary>
    ///  Creates an instance of a triangle.
    /// </summary>
    /// <param name="sideA">sets the value of the side A of the triangle</param>
    /// <param name="sideB">sets the value of the side B of the triangle</param>
    /// <param name="sideC">sets the value of the side C of the triangle</param>
    /// <returns></returns>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new ArgumentException("Side of triangle cannot be 0 or less than 0");
        }

        _sides = new[] { sideA, sideB, sideC };
    }
    
    public override double GetArea()
    {
        var halfMeter = (_sides[0] + _sides[1] + _sides[2]) / 2;
        var area = Math.Sqrt(halfMeter * (halfMeter - _sides[0]) * (halfMeter - _sides[1]) * (halfMeter - _sides[2]));
        return area;
    }
    
    /// <summary>
    ///  Checks whether the triangle is rectangular.
    /// </summary>
    /// <returns>
    /// True or False
    /// </returns>
    public bool IsRectangular()
    {
        var scrA = Math.Pow(_sides[0], 2);
        var scrB = Math.Pow(_sides[1], 2);
        var scrC = Math.Pow(_sides[2], 2);
        return Math.Abs(scrA + scrB - scrC) <= 0.001;
    }
}