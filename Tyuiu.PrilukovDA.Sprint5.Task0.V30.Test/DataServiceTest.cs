using Tyuiu.PrilukovDA.Sprint5.Task0.V30.Lib;

namespace Tyuiu.PrilukovDA.Sprint5.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
