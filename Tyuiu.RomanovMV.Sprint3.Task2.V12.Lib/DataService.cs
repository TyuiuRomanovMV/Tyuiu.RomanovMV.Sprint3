
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RomanovMV.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            do
            {
                double dis = (startValue + Math.Pow(value, startValue));
                double dis2 = 300 / dis;
                p *= Math.Pow(dis2, startValue);
                startValue++;
            } while ( startValue <= stopValue );
            
            return Math.Round(p ,3);
        }
    }
}
