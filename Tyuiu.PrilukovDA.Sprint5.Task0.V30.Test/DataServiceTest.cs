using Tyuiu.PrilukovDA.Sprint5.Task0.V30.Lib;

namespace Tyuiu.PrilukovDA.Sprint5.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "C:\\Users\\prilu\\source\\repos\\Tyuiu.PrilukovDA.Sprint5\\Tyuiu.PrilukovDA.Sprint5.Task0.V30\\bin\\Debug\\net8.0\\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);

            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
