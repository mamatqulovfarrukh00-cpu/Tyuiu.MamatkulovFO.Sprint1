using Tyuiu.MamatkulovFO.Sprint1.Task3.V11.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task3.V11.Test;




public class DataServiceTest
{
    private readonly DataService _service;

    public DataServiceTest()
    {
        _service = new DataService();
    }

    [Fact]
    public void CalculateTriangleArea_ValidCoordinates_ReturnsCorrectRoundedArea()
    {
        // Arrange
        double x1 = -2, y1 = 5;
        double x2 = 1, y2 = 7;
        double x3 = 5, y3 = -3;

        double expected = 19.0;

        // Act
        double actual = _service.CalculateTriangleArea(x1, y1, x2, y2, x3, y3);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Fact]
    public void CalculateTriangleArea_CollinearPoints_ReturnsZero()
    {
        double area = _service.CalculateTriangleArea(0, 0, 1, 1, 2, 2);
        Assert.AreEqual(0.0, area);
    }

    [Fact]
    public void CalculateTriangleArea_NegativeCoordinates_ReturnsPositiveArea()
    {
        double area = _service.CalculateTriangleArea(-1, -1, -2, -3, -4, -1);
        Assert.AreEqual(3.0, area);
    }

    [Fact]
    public void CalculateTriangleArea_RoundingToThreeDecimals_WorksCorrectly()
    {
        // Misol: yuz 12.34567 bo'lsa, 12.346 qaytishi kerak
        double area = _service.CalculateTriangleArea(0, 0, 3, 0, 0, 8.2311); // yuza = (3*8.2311)/2 = 12.34665 → 12.347
        Assert.AreEqual(12.347, area);
    }
}