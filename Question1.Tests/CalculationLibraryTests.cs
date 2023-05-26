using Question1.Library;
using Question1.Library.Figures;

namespace Question1.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AreaOfCircleWithSideOfOneIsCorrect()
    {
        var circle = new Circle(1);

        var circleArea = CalculationLibrary.CalculateArea(circle);
        
        Assert.That(Math.Abs(circleArea - Math.PI), Is.LessThan(CalculationLibrary.Tolerance));
    }

    [Test]
    public void AreaOfTriangleWithSidesOfOneIsCorrect()
    {
        var triangle = new Triangle(1, 1, Math.Sqrt(2));

        var triangleArea = CalculationLibrary.CalculateArea(triangle);
        
        Assert.That(Math.Abs(triangleArea - 0.5), Is.LessThan(CalculationLibrary.Tolerance));
    }

    [Test]
    public void AreasForPythagoreanTriplesAreCorrect()
    {
        var t1 = new Triangle(3, 4, 5);
        var t2 = new Triangle(161, 240, 289);
        var t3 = new Triangle(32, 255, 257);

        var t1Area = CalculationLibrary.CalculateArea(t1);
        var t2Area = CalculationLibrary.CalculateArea(t2);
        var t3Area = CalculationLibrary.CalculateArea(t3);
        
        Assert.Multiple(() =>
        {
            Assert.That(Math.Abs(t1Area - 6.0), Is.LessThan(CalculationLibrary.Tolerance));
            Assert.That(Math.Abs(t2Area - 19320.0), Is.LessThan(CalculationLibrary.Tolerance));
            Assert.That(Math.Abs(t3Area - 4080.0), Is.LessThan(CalculationLibrary.Tolerance));
        });
    }
}