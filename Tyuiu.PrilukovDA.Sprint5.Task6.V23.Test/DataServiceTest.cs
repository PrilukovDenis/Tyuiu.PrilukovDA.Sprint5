using Tyuiu.PrilukovDA.Sprint5.Task6.V23.Lib;

namespace Tyuiu.PrilukovDA.Sprint5.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\prilu\source\repos\Tyuiu.PrilukovDA.Sprint5\Tyuiu.PrilukovDA.Sprint5.Task6.V23\bin\Debug\net8.0\DataSprint5\InPutDataFileTask6V23.txt";

            int res = ds.LoadFromDataFile(path);

            Assert.AreEqual(7, res);
        }
    }
}
