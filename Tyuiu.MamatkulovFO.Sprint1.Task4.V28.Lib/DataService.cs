using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MamatkulovFO.Sprint1.Task4.V28.Lib;
using System;



public class DataService : ISprint1Task4V28
{
    public double CalculateFormula(double x, double y)
    {
        double numerator = Math.Cos(60 * Math.PI / 2); // 60*pi/2 = 30*pi → cos(30π) = cos(π) = -1
        double denominator = Math.Exp(2 * x + y);

        if (denominator == 0)
            throw new DivideByZeroException("Exp(2*x + y) nolga teng bo'lishi mumkin emas.");

        double result = numerator / denominator;
        return Math.Round(result, 3);
    }

    double ISprint1Task4V28.Calculate(double x, double y)
    {
        throw new NotImplementedException();
    }
}  