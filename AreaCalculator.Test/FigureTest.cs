using AreaCalculator;

namespace AreaCalculatorUnitTest;

public class FigureTest
{
    [Fact]
    public void Calculating_Area_Of_Triangle_Sides_3_4_5_Return_6()
    {
        var triangle = new Triangle(3, 4, 5);
        var rightAnswer = 6;
        var area = triangle.GetArea();
        Assert.Equal(rightAnswer, area);
    }
    
    [Fact]
    public void Calculating_Area_Of_Circle_Radius_3_Return_28_2743()
    {
        var circle = new Circle(3);
        var rightAnswer = 28.2743;
        var area = circle.GetArea();
        Assert.Equal(rightAnswer, area);
    }

    [Fact]
    public void Checks_Triangle_Is_Rectangular()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRectangular());
    }

    [Fact]
    public void Test_Invalid_Triangle()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
    }
    
    [Fact]
    public void Test_Invalid_Circle()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
    
}