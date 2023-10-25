namespace FiguresLibrary;

public class Circle : IFigure
{
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть больше нуля.");
        }
        
        Radius = radius;
    }
    public double Radius { get; set; }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}