using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MamatkulovFO.Sprint1.Task2.V17.Lib;



    public class DataService : ISprint1Task2V18
    {
        public int CalculateSideSquareParallelepiped(int value, int valueTwo, int valueThree)
        {
            int S = 2 * (value + valueTwo) * valueThree;
            return S;
        }
    }

