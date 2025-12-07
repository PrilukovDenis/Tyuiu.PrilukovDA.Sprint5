using Tyuiu.PrilukovDA.Sprint5.Task7.V14.Lib;

namespace Tyuiu.PrilukovDA.Sprint5.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\prilu\source\repos\Tyuiu.PrilukovDA.Sprint5\Tyuiu.PrilukovDA.Sprint5.Task7.V14\bin\Debug\net8.0\DataSprint5\InPutDataFileTask7V14.txt";

            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
