using Tyuiu.MamatkulovFO.Sprint1.Task6.V6.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task6.V6;


    class Program
    {
        static void Main()
        {
            var service = new DataService();

            Console.WriteLine("Введите текст:\n");

            Console.Write("-> ");
            string input = Console.ReadLine()!;

            string result = service.RemoveFirstLetterFromEachWord(input);

            Console.WriteLine($"\n{result}");
        }
    }