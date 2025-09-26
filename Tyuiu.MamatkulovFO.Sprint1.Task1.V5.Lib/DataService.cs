using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MamatkulovFO.Sprint1.Task1.V5.Lib
{
    public class DataService : ISprint1Task1V5

    {
        public double Calculate(double x, double y)
        {
            double res = 5 + (x * y / 3);
            return Math.Round(res,3);
        }
    }
}