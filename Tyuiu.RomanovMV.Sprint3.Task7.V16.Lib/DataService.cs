
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RomanovMV.Sprint3.Task7.V16.Lib
{
    public class DataService : ISprint3Task7V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] ValueArray = new double[length];
            double y; int count = 0;

            for (int x  = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Cos(x) / (x - 0.4) + Math.Sin(x) * 8 * x + 2), 2);
                ValueArray[count] = y;
                count++;
            }
            return ValueArray;
        }
    }
}
