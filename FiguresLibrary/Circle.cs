namespace FiguresLibrary;

public class Circle : IFigure
{
    public double Radius { get; set; }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}