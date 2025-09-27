using Tyuiu.MamatkulovFO.Sprint1.Task5.V7.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task5.V7.Test;


public class DataServiceTest
{
    private readonly DataService _service = new();

    [Fact]
    public void CalculateHours_90Degrees_Returns3()
    {
        int result = _service.CalculateHours(90);
        Assert.AreEqual(3, result);
    }

    [Fact]
    public void CalculateHours_100Degrees_Returns3()
    {
        int result = _service.CalculateHours(100);
        Assert.AreEqual(3, result);
    }

    [Fact]
    public void CalculateHours_29Degrees_Returns0()
    {
        int result = _service.CalculateHours(29);
        Assert.AreEqual(0, result);
    }

    [Fact]
    public void CalculateHours_359_9Degrees_Returns11()
    {
        int result = _service.CalculateHours(359.9);
        Assert.AreEqual(11, result);
    }

    [Fact]
    public void CalculateHours_InvalidValue_ThrowsException()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _service.CalculateHours(0));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _service.CalculateHours(360));
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => _service.CalculateHours(-10));
    }
}