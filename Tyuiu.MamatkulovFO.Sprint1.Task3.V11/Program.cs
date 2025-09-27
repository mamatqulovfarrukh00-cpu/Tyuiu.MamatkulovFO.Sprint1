using Tyuiu.MamatkulovFO.Sprint1.Task3.V11.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task3.V11;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты углов (числа разделяйте пробелом):\n");

        Console.Write("x1 -> ");
        double x1 = double.Parse(Console.ReadLine()!);

        Console.Write("y1 -> ");
        double y1 = double.Parse(Console.ReadLine()!);

        Console.Write("x2 -> ");
        double x2 = double.Parse(Console.ReadLine()!);

        Console.Write("y2 -> ");
        double y2 = double.Parse(Console.ReadLine()!);

        Console.Write("x3 -> ");
        double x3 = double.Parse(Console.ReadLine()!);

        Console.Write("y3 -> ");
        double y3 = double.Parse(Console.ReadLine()!);

        double area = Triangle.CalculateArea(x1, y1, x2, y2, x3, y3);

        Console.WriteLine($"\nПлощадь треугольника: {area} кв.см");
    }
}
  