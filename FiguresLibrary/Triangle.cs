namespace FiguresLibrary;

public class Triangle : IFigure
{
    public Triangle(double SideA, double SideB, double SideC)
    {
        if (SideA <= 0 || SideB <= 0 || SideC <= 0 ||
            SideA + SideB <= SideC ||
            SideA + SideC <= SideB ||
            SideB + SideC <= SideA)
        {
            throw new ArgumentException("Неккоректные длины сторон треугольника.");
        }
        
        this.SideA = SideA;
        this.SideB = SideB;
        this.SideC = SideC;
    }
    
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

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