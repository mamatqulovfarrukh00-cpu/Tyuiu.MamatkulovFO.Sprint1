using Tyuiu.MamatkulovFO.Sprint1.Task7.V15.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task7.V15;


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            try
            {
                double result = Calculator.Calculate(x);
                Console.WriteLine($"Результат: {result:F3}");
            }
            catch (System.ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
internal class Calculator
{
    internal static double Calculate(double x)
    {
        throw new NotImplementedException();
    }
}