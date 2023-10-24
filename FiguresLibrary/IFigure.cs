namespace FiguresLibrary
{
    public interface IFigure
    {
        /// <summary>
        /// Вычисляет и возвращает площадь фигуры.
        /// </summary>
        /// <returns>Площадь фигуры в виде <c>double</c></returns>
        double GetArea();
    }
}