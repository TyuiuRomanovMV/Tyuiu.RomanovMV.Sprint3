
using Tyuiu.RomanovMV.Sprint3.Task3.V11.Lib;

namespace Tyuiu.RomanovMV.Sprint3.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService(); 

            string str = "sqwreq vqwqq q";
            char str2 = 'q'; char str3 = '7';


            string res = ds.ReplaceCharOnNum(str, str2, str3);
            string wait = "s7wre7 v7w77 7";

            Assert.AreEqual(wait, res);
        }
    }
}
