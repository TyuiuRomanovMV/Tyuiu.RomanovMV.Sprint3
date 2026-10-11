
using Tyuiu.RomanovMV.Sprint3.Task1.V10.Lib;

namespace Tyuiu.RomanovMV.Sprint3.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 5; int x1 = 1; int x2 = 17;

            double res = ds.GetSumSeries(value, x1, x2);
            double wait = 0.168;

            Assert.AreEqual(res, wait);

        }
    }
}
