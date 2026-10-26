
using Tyuiu.RomanovMV.Sprint3.Task7.V16.Lib;

namespace Tyuiu.RomanovMV.Sprint3.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int s1 = -5; int s2 = 5;
            int len = s2 - s1 + 1;
            double[] Array = new double[len];

            Array[0] = -36.41;
            Array[1] = -22.07;
            Array[2] = 5.68;
            Array[3] = 16.72;
            Array[4] = 8.35;
            Array[5] = -0.5;
            Array[6] = 9.63;
            Array[7] = 16.29;
            Array[8] = 5.01;
            Array[9] = -22.40;
            Array[10] = -36.3;

            double[] res = new double[len];
            res = ds.GetMassFunction(s1, s2);

            CollectionAssert.AreEqual(res, Array);

        }
    }
}
