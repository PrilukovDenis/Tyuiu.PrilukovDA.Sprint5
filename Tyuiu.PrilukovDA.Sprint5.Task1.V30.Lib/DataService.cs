using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PrilukovDA.Sprint5.Task1.V30.Lib
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            StringBuilder sb = new StringBuilder();

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2 - 2 * x;
                double result;

                if (Math.Abs(denominator) < 1e-12)
                {
                    result = 0;
                }
                else
                {
                    result = Math.Cos(x) + Math.Sin(x) / denominator - 4 * x;
                }

                result = Math.Round(result, 2);
                sb.AppendLine(result.ToString());
            }

            File.WriteAllText(path, sb.ToString());
            return path;
        }
    }
}
