
using Tyuiu.RomanovMV.Sprint3.Task5.V14.Lib;

namespace Tyuiu.RomanovMV.Sprint3.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5; int start1 = 1; int stop1 = 3; int start2 = 1; int stop2 = 14;

            double res = ds.GetSumSumSeries(x,start1,start2, stop1, stop2);
            double wait = -31.275;
            Assert.AreEqual(res, wait);
        }
    }
}
