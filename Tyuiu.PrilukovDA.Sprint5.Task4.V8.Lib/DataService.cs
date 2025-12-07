using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PrilukovDA.Sprint5.Task4.V8.Lib
{
    public class DataService : ISprint5Task4V8
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path).Replace('.', ','); ;
            double res = Math.Round(((Convert.ToDouble(strX) * Convert.ToDouble(strX)) / Math.Sin(Convert.ToDouble(strX))) + 3, 3);
            return res;
        }
    }
}
