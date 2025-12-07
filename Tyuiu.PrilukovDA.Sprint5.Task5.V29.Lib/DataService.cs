using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PrilukovDA.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double minTwoDigit = double.MaxValue;
            bool found = false;

            foreach (string line in lines)
            {
                string trimmed = line.Trim();
                if (string.IsNullOrEmpty(trimmed)) continue;

                if (double.TryParse(trimmed.Replace('.', ','), NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                {
                    if (Math.Abs(num % 1) < 1e-12)
                    {
                        int intNum = (int)num;
                        if ((intNum >= 10 && intNum <= 99) || (intNum <= -10 && intNum >= -99))
                        {
                            if (intNum < minTwoDigit)
                            {
                                minTwoDigit = intNum;
                                found = true;
                            }
                        }
                    }
                }
            }

            if (!found)
            {
                return 0;
            }

            return minTwoDigit;
        }
    }
}
