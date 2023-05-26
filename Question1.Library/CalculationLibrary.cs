using Question1.Library.Figures;

namespace Question1.Library;

public static class CalculationLibrary
{
    public static double Tolerance { get; set; } =  0.00000001;
    
    public static double CalculateArea(IFigure figure) => figure.Area;
}