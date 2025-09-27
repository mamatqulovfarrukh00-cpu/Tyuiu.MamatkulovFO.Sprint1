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
    public void TriangleArea_WithGivenPoints_ReturnsCorrectArea()
    {
        // Arrange
        double x1 = -2, y1 = 5;
        double x2 = 1, y2 = 7;
        double x3 = 5, y3 = -3;

        double expected = 19.0;

        // Act
        double actual = _service.TriangleArea(x1, y1, x2, y2, x3, y3);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Fact]
    public void TriangleArea_CollinearPoints_ReturnsZero()
    {
        double area = _service.TriangleArea(0, 0, 1, 1, 2, 2);
        Assert.AreEqual(0.0, area);
    }
}