





using System.CodeDom.Compiler;
using Tyuiu.MamatkulovFO.Sprint1.Task2.V17.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedCalculateSideSquareParallelepiped()
        {
            DataService ds = new DataService();
            int valueOne = 4;
            int valueTwo = 8;
            int valueThree = 6;
            var res = ds.CalculateSideSquareParallelepiped(valueOne, valueTwo, valueThree);
            int wait = 144;
            Assert.AreEqual(res, wait);
        }
    }
}