using System.Diagnostics.Tracing;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MamatkulovFO.Sprint1.Task2.V17.Lib;


using System;


    public class DataService : ISprint1Task2V17
    {
    
        public int ConvertMinutesToHours(int minutes)
        {
            return minutes / 60;
        }

        // Boshqa funksiyalar (agar kerak bo'lsa)
        public int CalculateSideSquareParallelepiped(int length, int width, int height)
        {
            return 2 * (length * height + width * height);
        }
    }
