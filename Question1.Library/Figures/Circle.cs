namespace Question1.Library.Figures;

public class Circle : IFigure
{
    private readonly double _radius;
    
    public Circle(double radius)
    {
        _radius = radius;
    }
    
    public double Area => _radius * _radius * Math.PI;
}