using Tyuiu.MamatkulovFO.Sprint1.Task7.V15.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task7.V15.Test;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Calculate_WithX5_Returns96_484()
    {
        double result = Calculator.Calculate(5);
        Assert.AreEqual(96.484, result, 0.001);
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentException))]
    public void Calculate_WhenDenominatorZero_ThrowsException()
    {
        Calculator.Calculate(0); // x=0 → знаменатель = 0
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentException))]
    public void Calculate_WhenDenominatorZero_ThrowsException_For_Sqrt15()
    {
        Calculator.Calculate(Math.Sqrt(15)); // x^3 - 15x = 0
    }

    private class Calculator
    {
        internal static double Calculate(int v)
        {
            throw new NotImplementedException();
        }

        internal static void Calculate(double v)
        {
            throw new NotImplementedException();
        }
    }
}
