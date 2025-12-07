using Tyuiu.PrilukovDA.Sprint5.Task2.V27.Lib;

namespace Tyuiu.PrilukovDA.Sprint5.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix =
            {
                { 1, 4, 3 }, { 1, 1, 4 }, { 4, 3, 8 }
            };
            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
