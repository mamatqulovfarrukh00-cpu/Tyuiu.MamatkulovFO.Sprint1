using Tyuiu.MamatkulovFO.Sprint1.Task4.V28.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task4.V28.Test;


public class DataServiceTest
{
    private readonly DataService _service = new();

    [Fact]
    public void CalculateFormula_ValidInput_ReturnsCorrectRoundedResult()
    {
        // Arrange
        double x = 1.0;
        double y = 1.0;
        // cos(60*pi/2) = cos(30*pi) = -1
        // Exp(2*1 + 1) = Exp(3) ≈ 20.0855
        // -1 / 20.0855 ≈ -0.049787 → -0.050
        double expected = -0.050;

        // Act
        double actual = _service.CalculateFormula(x, y);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Fact]
    public void CalculateFormula_ZeroExponent_ReturnsNegativeOne()
    {
        // Agar 2x + y = 0 → Exp(0) = 1 → natija = cos(...) / 1 = -1
        double actual = _service.CalculateFormula(0, 0);
        Assert.AreEqual(-1.0, actual);
    }
}