
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RomanovMV.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum2 = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                double sum = 0; 
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum = sum + Math.Sin(x) + 2 / k;
                }
                sum2 = sum2 + sum;
            }
            return Math.Round(sum2, 3);
        }
    }
}
