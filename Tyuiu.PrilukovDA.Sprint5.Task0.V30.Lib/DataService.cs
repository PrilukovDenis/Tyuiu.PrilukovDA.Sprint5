using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PrilukovDA.Sprint5.Task0.V30.Lib
{
    public class DataService : ISprint5Task0V30
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            double denominator = 3 * x + 4;
            double y = denominator != 0 ? (x * x + 1) / denominator : 0;
            y = Math.Round(y, 2);

            File.WriteAllText(path, y.ToString());
            return path;
        }
    }
}
