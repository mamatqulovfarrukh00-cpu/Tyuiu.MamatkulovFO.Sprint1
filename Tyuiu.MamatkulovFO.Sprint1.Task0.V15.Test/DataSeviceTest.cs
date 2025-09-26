using Tyuiu.MamatkulovFO.Sprint1.Task0.V15.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task0.V15.Test
{
    [TestClass]
    public sealed class DataSeviceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var wait = 24;
            var res = ds.Calculate();
            Assert.AreEqual(wait, res);
        }
    }
}
