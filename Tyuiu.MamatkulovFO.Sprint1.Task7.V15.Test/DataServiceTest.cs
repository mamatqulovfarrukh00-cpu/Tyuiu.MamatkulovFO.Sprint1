using Tyuiu.MamatkulovFO.Sprint1.Task7.V15.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task7.V15.Test;
[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void ValidInput_ReturnsCorrectResult()
    {
       
       
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentException))]
    public void InvalidY_ThrowsException()
    {
        Calculator.Calculate(1, -1);
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentException))]
    public void InvalidX_ThrowsException()
    {
        Calculator.Calculate(-2, 1);
    }

    [TestMethod]
    [ExpectedException(typeof(System.ArgumentException))]
    public void ZeroDenominator_ThrowsException()
    {
        Calculator.Calculate(1, -1);
    }

    private class Calculator
    {
        internal static void Calculate(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }

}