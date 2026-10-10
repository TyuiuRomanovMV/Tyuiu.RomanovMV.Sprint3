
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RomanovMV.Sprint3.Task0.V5.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double S = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                S = S + Math.Pow((1 / Math.Sin(i)), 2);

            }
            return Math.Round(S, 3);
        }
    }
}
