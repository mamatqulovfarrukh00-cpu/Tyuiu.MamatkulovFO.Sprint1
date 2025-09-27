





using System.CodeDom.Compiler;
using Tyuiu.MamatkulovFO.Sprint1.Task2.V17.Lib;
namespace Tyuiu.MamatkulovFO.Sprint1.Task2.V17.Test;


    public class DataService
    {
        public static Int32 CalculateSideSquareParallelepiped(Int32 length, Int32 width, Int32 height)
        {
            return 2 * (length * height + width * height);
        }
    }
