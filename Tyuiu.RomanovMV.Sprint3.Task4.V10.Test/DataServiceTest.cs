
using System.Security.Cryptography;
using Tyuiu.RomanovMV.Sprint3.Task4.V10.Lib;

namespace Tyuiu.RomanovMV.Sprint3.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x1 = -5; int x2 = 5;
            double res = ds.Calculate(x1, x2); double wait = 0.014;
            Assert.AreEqual(res, wait);
        }
    }
}
