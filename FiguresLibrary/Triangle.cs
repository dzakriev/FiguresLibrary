namespace FiguresLibrary;

public class Triangle : IFigure
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0 ||
            sideA + sideB <= sideC ||
            sideA + sideC <= sideB ||
            sideB + sideC <= sideA)
        {
            throw new ArgumentException("Неккоректные длины сторон треугольника.");
        }
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public double GetArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    /// <summary>
    /// Проверяет, является ли треугольник прямоугольным.
    /// </summary>
    /// <returns><c>true</c>, если треугольник является прямоугольным; иначе - <c>false</c>.</returns>
    public bool IsRightTriangle()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        // добавил порог 1e-10 для избежания проблем из-за потери точности
        double tolerance = 1e-10;
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < tolerance;
    }
}