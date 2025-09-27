using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MamatkulovFO.Sprint1.Task7.V15.Lib;

public class DataService: ISprint1Task7V15
{
    public static double Calculate(double x, double y)
    {
        if (x <= -1 || y < 0 || Math.Abs(x + y) < 1e-10)
            throw new ArgumentException("Недопустимые значения x или y.");

        double result = (x * x + Math.Sqrt(y)) / (x + y) + Math.Log(x + 1);
        return Math.Round(result, 3);
    }

    double ISprint1Task7V15.Calculate(double x)
    {
        throw new NotImplementedException();
    }
}