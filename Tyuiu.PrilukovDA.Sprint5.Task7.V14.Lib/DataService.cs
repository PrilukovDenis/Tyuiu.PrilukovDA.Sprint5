using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.PrilukovDA.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V14.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExst = fileInfo.Exists;

            if(fileExst)
            {
                File.Delete(pathSaveFile);
            }

            char[] chars = File.ReadAllText(path).ToCharArray();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] >= 'a' && chars[i] <= 'z')
                    {
                        chars[i] = char.ToUpper(chars[i]);
                    }
                }
            }

            File.WriteAllText(pathSaveFile, new string(chars));
            return pathSaveFile;
        }
    }
}
