
using Tyuiu.RomanovMV.Sprint3.Task6.V15.Lib;

namespace Tyuiu.RomanovMV.Sprint3.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x1 = 6; int x2 = 15;
            int res = ds.GetSumTheDivisors(x1, x2);
            int wait = 168;
            Assert.AreEqual(res, wait);

        }
    }
}
