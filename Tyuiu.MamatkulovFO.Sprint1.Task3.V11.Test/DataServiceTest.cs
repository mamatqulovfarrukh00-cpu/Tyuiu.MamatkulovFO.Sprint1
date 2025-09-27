using Tyuiu.MamatkulovFO.Sprint1.Task3.V11.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task3.V11.Test;


public class TriangleTests
{
    [Fact]
    public void CalculateArea_ValidCoordinates_ReturnsCorrectRoundedArea()
    {
        // Arrange
        double x1 = -2, y1 = 5;
        double x2 = 1, y2 = 7;
        double x3 = 5, y3 = -3;

        double expected = 19.0;
        
        // Act
        double actual = Triangle.CalculateArea(x1, y1, x2, y2, x3, y3);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Fact]
    public void CalculateArea_ZeroAreaTriangle_ReturnsZero()
    {
        // Три коллинеарные точки
        double area = Triangle.CalculateArea(0, 0, 1, 1, 2, 2);
        Assert.AreEqual(0.0, area);
    }

    [Fact]
    public void CalculateArea_NegativeCoordinates_ReturnsPositiveArea()
    {
        double area = Triangle.CalculateArea(-1, -1, -2, -3, -4, -1);
        Assert.IsTrue(area > 0);
        Assert.AreEqual(3.0, area); // Проверка вручную: |(-1*(-3+1) + -2*(-1+1) + -4*(-1+3))/2| = |(2 + 0 -8)/2| = |-3| = 3
    }
}