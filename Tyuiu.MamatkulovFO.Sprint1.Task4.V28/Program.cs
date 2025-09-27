using Tyuiu.MamatkulovFO.Sprint1.Task4.V28.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task4.V28;
   

class Program
{
    static void Main()
    {
        var service = new DataService();

        Console.WriteLine("Введите исходные данные:\n");

        Console.Write("x -> ");
        double x = double.Parse(Console.ReadLine()!);

        Console.Write("y -> ");
        double y = double.Parse(Console.ReadLine()!);

        double result = service.CalculateFormula(x, y);

        Console.WriteLine($"\nРезультат: {result:F3}");
    }
}
   