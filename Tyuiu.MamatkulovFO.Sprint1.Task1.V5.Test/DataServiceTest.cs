using Tyuiu.MamatkulovFO.Sprint1.Task1.V5.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            var wait = 13.333;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
