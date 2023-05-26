namespace Question1.Library.Figures;

public class Triangle : IFigure
{
    #region Private fields

    private double _sideA;
    private double _sideB;
    private double _hypotenuse;

    #endregion

    #region Ctor

    public Triangle(double a, double b, double c)
    {
        if (!CheckIfValidTriangle(a, b, c))
        {
            throw new ArgumentException("Could not build a triangle with given sides.");
        }

        SetArea(a, b, c);
    }

    #endregion
    
    public double Area { get; private set; }

    #region Private methods
    
    private void SetArea(double a, double b, double c)
    {
        SetSides(a, b, c);

        var isRight = Math.Abs(_hypotenuse * _hypotenuse - (_sideA * _sideA + _sideB * _sideB)) < CalculationLibrary.Tolerance;
        if (isRight)
        {
            Area = _sideA * _sideB / 2;
        }
        
        var p = (a + b + c) / 2;
        
        Area = Math.Sqrt(p * (p - a)* (p - b)* (p-c));
    }
    
    private void SetSides(double a, double b, double c)
    {
        var maxLength = MaxOfThree(a, b, c);

        if (Math.Abs(maxLength - a) < CalculationLibrary.Tolerance)
        {
            _hypotenuse = a;
            _sideA = b;
            _sideB = c;
        }
        else if (Math.Abs(maxLength - b) < CalculationLibrary.Tolerance)
        {
            _hypotenuse = b;
            _sideA = a;
            _sideB = c;
        }
        else
        {
            _hypotenuse = c;
            _sideA = a;
            _sideB = b;
        }
    }

    private static bool CheckIfValidTriangle(double a, double b, double c)
    {
        return !(c > a + b) && !(a > b + c) && !(b > a + c);
    }

    private static double MaxOfThree(double x, double y, double z) => Math.Max(Math.Max(x, y), z);

    #endregion
}