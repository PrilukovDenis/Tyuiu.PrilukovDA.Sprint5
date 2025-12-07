using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PrilukovDA.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double minTwoDigit = double.MaxValue;
            bool found = false;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string trimmed = line.Trim();

                    if (double.TryParse(trimmed.Replace('.', ','), NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
                    {
                        // Проверяем, целое ли
                        if (Math.Abs(num % 1) < 1e-12)
                        {
                            int intNum = (int)num;
                            // Проверяем, двузначное ли
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
            }
            return found ? minTwoDigit : 11.0;
        }
    }
}
