namespace FiguresLibrary.Tests;

using NUnit.Framework;
using System;

public class AreaCalculatorTests
{
    [Test]
    public void CalculateCircleArea()
    {
        Circle circle = new Circle(5);
        double expectedArea = Math.PI * 5 * 5;
        double actualArea = circle.GetArea();

        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-10));
    }
    
    [Test]
    public void CalculateRightTriangleArea()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;
        double actualArea = triangle.GetArea();

        Assert.That(actualArea, Is.EqualTo(expectedArea));
    }
    
    [Test]
    public void CalculateTriangleArea()
    {
        Triangle triangle = new Triangle(3, 25, 26);
        double expectedArea = 36;
        double actualArea = triangle.GetArea();

        Assert.That(actualArea, Is.EqualTo(expectedArea));
    }
    
    [Test]
    public void CalculateRegularTriangleArea()
    {
        Triangle triangle = new Triangle(3, 3, 3);

        double s = 4.5;
        double expectedArea = Math.Sqrt(s * (s - 3) * (s - 3) * (s - 3));
        double actualArea = triangle.GetArea();

        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-10));
    }
    
    [Test]
    public void CalculateTriangleFloatArea()
    {
        Triangle triangle = new Triangle(3, 4, 6);
        double s = 6.5;
        double expectedArea = Math.Sqrt(s * (s - 3) * (s - 4) * (s - 6));
        double actualArea = triangle.GetArea();

        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-10));
    }
    
    [Test]
    public void CheckIsRightTriangle()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        bool isRight = triangle.IsRightTriangle();

        Assert.That(isRight, Is.EqualTo(true));
    }
    
    [Test]
    public void CheckIsNotRightTriangle()
    {
        Triangle triangle = new Triangle(4, 4, 5);
        bool isRight = triangle.IsRightTriangle();

        Assert.That(isRight, Is.EqualTo(false));
    }
    
    [Test]
    public void CalculateAreaCompileTime()
    {
        IFigure shape1 = new Circle(5);
        IFigure shape2 = new Triangle(3, 4, 5);

        double expectedCircleArea = 5 * 5 * Math.PI;
        double actualCircleArea = shape1.GetArea();
        
        double expectedTriangleArea = 6;
        double actualTriangleArea = shape2.GetArea();

        Assert.That(actualCircleArea, Is.EqualTo(expectedCircleArea).Within(1e-10));
        Assert.That(actualTriangleArea, Is.EqualTo(expectedTriangleArea));
    }

    [Test]
    public void WrongArgumentsCheck()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
        Assert.Throws<ArgumentException>(() => new Circle(-12.1));
        Assert.Throws<ArgumentException>(() => new Triangle(1,2,3));
        Assert.Throws<ArgumentException>(() => new Triangle(0,2,3));
        Assert.Throws<ArgumentException>(() => new Triangle(-3,-4,-5));
        Assert.Throws<ArgumentException>(() => new Triangle(-3,4,5));
    }
}