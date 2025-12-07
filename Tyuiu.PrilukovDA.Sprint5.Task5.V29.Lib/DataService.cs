using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PrilukovDA.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int minTwoDigit = int.MaxValue;

            foreach (string line in lines)
            {
                string trimmed = line.Trim();
                if (string.IsNullOrEmpty(trimmed)) continue;

                if (int.TryParse(trimmed, out int num))
                {
                    if ((num >= 10 && num <= 99) || (num <= -10 && num >= -99))
                    {
                        if (num < minTwoDigit)
                        {
                            minTwoDigit = num;
                        }
                    }
                }

            }

            if (minTwoDigit == int.MaxValue)
            {
                return 0;
            }

            return minTwoDigit;
        }
    }
}
