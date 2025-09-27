using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MamatkulovFO.Sprint1.Task7.V15.Lib;


public class DaraService : ISprint1Task7V15
    {

    double ISprint1Task7V15.Calculate(double x)
    {
        throw new NotImplementedException();
    }


public static double Calculate(double x)
        {
            // Шарт: знаменатель не должен быть равен нулю
            if (Math.Abs(x * x * x - 15 * x) < 1e-10)
                throw new System.ArgumentException("Знаменатель равен нулю. Деление на ноль невозможно.");

            double part1 = Math.Abs(x * x - x * x * x); // |x² - x³|
            double numerator = Math.Cos(x * x * x) + 7 * x * x; // cos(x³) + 7x²
            double denominator = x * x * x - 15 * x; // x³ - 15x

            double result = part1 - numerator / denominator;
            return Math.Round(result, 3);
        }
    }
