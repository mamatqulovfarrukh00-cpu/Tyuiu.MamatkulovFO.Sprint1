using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MamatkulovFO.Sprint1.Task5.V7.Lib;


public class DataService : ISprint1Task5V7
{
    
    public int CalculateHours(double f)
    {
        if (f <= 0 || f >= 360)
            throw new ArgumentOutOfRangeException(nameof(f), "f must be in range (0, 360).");

        // Soat milining 1 soatda 30 gradus buriladi
        double totalHours = f / 30.0;

        // Faqat butun qism — to'liq o'tgan soatlar
        int hours = (int)Math.Floor(totalHours);

        // Birinchi yarmi — 0 dan 11 gacha (lekin f < 360 bo'lsa, 11 gacha bo'ladi)
        return hours;
    }

    int ISprint1Task5V7.AngleToHoursMinutes(double f)
    {
        throw new NotImplementedException();
    }
}