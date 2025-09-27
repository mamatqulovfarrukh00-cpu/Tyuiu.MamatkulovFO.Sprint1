using Tyuiu.MamatkulovFO.Sprint1.Task7.V15.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task7.V15;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = Calculator.Calculate(x, y);
            Console.WriteLine($"Результат: {result:F3}");
        }

    private class Calculator
    {
        internal static double Calculate(double x, double y)
        {
            throw new NotImplementedException();
        }
    }
}
