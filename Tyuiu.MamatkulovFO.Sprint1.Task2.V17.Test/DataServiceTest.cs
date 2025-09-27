using Tyuiu.MamatkulovFO.Sprint1.Task2.V17.Lib;

namespace Tyuiu.MamatkulovFO.Sprint1.Task2.V17.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void CheckedConvertMinutesToHours()
            
        {
            DataService ds = new DataService();
            int minutes = 144;
            int expected = 2; 
            int result = ds.ConvertMinutesToHours(minutes);
            Assert.AreEqual(expected, result);
        }

        
        [Test]
        public void CheckedCalculateSideSquareParallelepiped()
        {
            DataService ds = new DataService();
            int length = 4;
            int width = 8;
            int height = 6;
            int expected = 144;
            int result = ds.CalculateSideSquareParallelepiped(length, width, height);
            Assert.AreEqual(expected, result);
        }
    }
}