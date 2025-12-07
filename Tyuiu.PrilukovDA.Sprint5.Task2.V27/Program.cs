using Tyuiu.PrilukovDA.Sprint5.Task2.V27.Lib;

DataService ds = new DataService();
int[,] matrix =
{
    { 1, 4, 3 }, { 1, 1, 4 }, { 4, 3, 8 }
};

string res = ds.SaveToFileTextData(matrix);

Console.WriteLine("Файл создан: " + res);

Console.WriteLine("Содержимое: " + File.ReadAllText(res));