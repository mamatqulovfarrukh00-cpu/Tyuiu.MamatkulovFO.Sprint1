using Tyuiu.MamatkulovFO.Sprint1.Task5.V7.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task5.V7;


class Program
{
    static void Main()
    {
        var service = new DataService();

        Console.WriteLine("Введите угол поворота часовой стрелки (в градусах):\n");

        Console.Write("f -> ");
        double f = double.Parse(Console.ReadLine()!);

        int hours = service.CalculateHours(f);

        Console.WriteLine($"\nh = {hours}");
    }
}