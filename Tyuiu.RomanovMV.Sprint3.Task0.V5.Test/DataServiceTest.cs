

using Tyuiu.RomanovMV.Sprint3.Task0.V5.Lib;

namespace Tyuiu.RomanovMV.Sprint3.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int x1 = 1; int x2 = 10;

            double res = ds.GetSumSeries(x1, x2);

            double wait = 81.083;

            Assert.AreEqual(res, wait);
        }
    }
}