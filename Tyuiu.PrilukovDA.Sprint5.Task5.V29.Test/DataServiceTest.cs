using Tyuiu.PrilukovDA.Sprint5.Task5.V29.Lib;

namespace Tyuiu.PrilukovDA.Sprint5.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            string path = @"C:\Users\prilu\source\repos\Tyuiu.PrilukovDA.Sprint5\Tyuiu.PrilukovDA.Sprint5.Task5.V29\bin\Debug\net8.0\DataSprint5\InPutDataFileTask5V29.txt";

            FileInfo fileInfo = new FileInfo(path);
            Assert.AreEqual(true, fileInfo.Exists);
        }
    }
}
