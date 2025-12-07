using Tyuiu.PrilukovDA.Sprint5.Task6.V23.Lib;

DataService ds = new DataService();

string path = $@"{Directory.GetCurrentDirectory()}InPutDataFileTask6V23.txt";


double result = ds.LoadFromDataFile(path);
Console.WriteLine("Результат: " + result);