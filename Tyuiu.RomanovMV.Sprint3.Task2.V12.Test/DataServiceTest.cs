
using Tyuiu.RomanovMV.Sprint3.Task2.V12.Lib;

namespace Tyuiu.RomanovMV.Sprint3.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int x = 5; int x2 = 1; int x3 = 5;

            double res = ds.GetMultiplySeries(x, x2, x3);

            double wait = 0.033;

            Assert.AreEqual(res, wait);
        }
    }
}
